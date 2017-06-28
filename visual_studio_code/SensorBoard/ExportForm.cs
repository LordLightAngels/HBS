using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace SensorBoard
{
    public partial class ExportForm : Form
    {
        private String filePath;

        public ExportForm()
        {
            InitializeComponent();
        }

        public void ExportDataCSV(String filePath)
        {
            List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();
            resultset = Sensor.getAllSensors();

            var csv = new StringBuilder();

            String finalRes = "\"label\";\"UID\";\"Date et heure\";\"Température\";\"Humidité\";" + System.Environment.NewLine;

            foreach (Dictionary<String, String> line in resultset)
            {
                String res = "";
                res += "\"" + line["label"] + "\";";
                res += "\"" + line["uid"] + "\";";
                res += "\"" + line["data_date"] + "\";";
                res += "\"" + line["temperature"] + "\";";
                res += "\"" + line["humidity"] + "%\";";
                finalRes += res + System.Environment.NewLine;
            }

            try
            {
                File.WriteAllText(filePath, finalRes.ToString());

                if (mcbOuvrir.Checked)
                {
                    Process.Start(filePath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à l'enregistrement: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ExportDataPDF(string filePath)
        {

            FileStream fs = new FileStream(filePath, FileMode.Create);
            // Create an instance of the document class which represents the PDF document itself.
            Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestream in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);


            // Open the document to enable you to write to the document
            doc.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner
            doc.Add(new Paragraph("Phrase test à changer"));

            PdfPTable table = new PdfPTable(5);

            table.HorizontalAlignment = 0;
            //leave a gap before and after the table
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            PdfPCell cell0 = new PdfPCell(new Phrase("Rapport"));
            cell0.Colspan = 5;
            cell0.Border = 0;
            cell0.HorizontalAlignment = 1;
            table.AddCell(cell0);
            table.AddCell("Nom du capteur");
            table.AddCell("UID du capteur");
            table.AddCell("Date-heure du relevé");
            table.AddCell("Température");
            table.AddCell("Humidité");
            

            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            SynthesisForm synthesis = main.getSynthesis();
            DateTime start = main.GetStartDate();
            DateTime end = main.GetEndDate();
            String startString = start.ToString("yyyy-MM-dd hh:mm:ss");
            String endString = end.ToString("yyyy-MM-dd hh:mm:ss");
            String idSensor = main.getSensor();
            String query;
            String optionalClause = "WHERE 1 ";

            if (idSensor != "")
            {
                optionalClause = "WHERE sensor.id = " + idSensor + "  ";
            }

            query = "SELECT  sensor.*, data.*" +
                    "FROM sensor INNER JOIN data " +
                    "ON data.sensor = sensor.id " +
                    optionalClause + " " +
                    "AND (data_date BETWEEN '" + startString + "' AND '" + endString + "') " +
                    "ORDER BY sensor ASC, data_date ASC";

            List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();

            try
            {
                resultset = DBInteractor.QuickSelect(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            foreach (Dictionary<String, String> line in resultset)
            {
                table.AddCell(line["label"].ToString());
                table.AddCell(line["uid"].ToString());
                table.AddCell(line["data_date"].ToString());
                table.AddCell(line["temperature"].ToString());
                table.AddCell(line["humidity"].ToString());
            }

            doc.Add(table);

            //Stream chTempHumidImageBuffer = synthesis.getCHTempHumidImageBuffer();
            //iTextSharp.text.Image iImage = iTextSharp.text.Image.GetInstance(chTempHumidImageBuffer);
            //doc.Add(iImage);


            doc.Add(new Phrase("Amplitude temporelle des relevés : " + main.getSynthesis().tfAmplitude.Text + Environment.NewLine));
            doc.Add(new Phrase("Date et heure du dernier relevé : " + main.getSynthesis().tfdtEnd.Text + Environment.NewLine));
            doc.Add(new Phrase("Date et heure du premier relevé : " + main.getSynthesis().tfdtStart.Text + Environment.NewLine));
            doc.Add(new Phrase(main.getSynthesis().tfLabel.Text + Environment.NewLine));
            doc.Add(new Phrase(main.getSynthesis().tfNbr.Text + Environment.NewLine));
            doc.Add(new Phrase(main.getSynthesis().tfUID.Text + Environment.NewLine));


            // Close the document
            doc.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity
            fs.Close();
            
            try
            {
                if (mcbOuvrir.Checked)
                {
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à l'enregistrement: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SendMail()
        {
            try
            {
                String query;
                query = "SELECT * FROM configuration ";

                List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();

                try
                {
                    resultset = DBInteractor.QuickSelect(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                        ex.Message + "\n\r" + ex.StackTrace);
                }
                String mailUser;
                String mailPassword;
                mailUser = resultset[0]["key"];
                mailPassword = resultset[0]["value"];


                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                String destAddress = tfInputEmail.Text;
                if (!Function.IsValidEmailAddress(destAddress)) throw new Exception("Veuillez saisir une adresse mail valide !"); 

                mail.From = new MailAddress("cobralerte@gmail.com");
                mail.To.Add(destAddress);
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";
                mail.Attachments.Add(new Attachment(filePath));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(mailUser, mailPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail envoyé avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi: " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mrbExport_Click(object sender, EventArgs e)
        {

            if (!mrbExcel.Checked && !mrbPDF.Checked)
            {
                MessageBox.Show("Veuillez saisir un format d'export");
            }
            else
            {
                MainForm mf = (MainForm)this.ParentForm;
                SaveFileDialog saveFile = new SaveFileDialog();
                String name = Function.slugify(mf.getSensorName());
                name = String.IsNullOrEmpty(name) ? "Tout-capteur" : name;
                saveFile.FileName = name;
                saveFile.DefaultExt = (mrbExcel.Checked ? "csv" : "pdf");
                if (saveFile.ShowDialog() == DialogResult.OK)
                {

                    this.filePath = saveFile.FileName;
                    if (mcbEnvoiDoc.Checked) SendMail();
                    if (mrbExcel.Checked) ExportDataCSV(saveFile.FileName);
                    if (mrbPDF.Checked) ExportDataPDF(saveFile.FileName);
                }
            }

        }

        private void tfInputEmail_Click(object sender, EventArgs e)
        {
            if (!tfInputEmail.Text.Contains("@"))
            {
                tfInputEmail.Text = "";
            }
        }
    }
}
