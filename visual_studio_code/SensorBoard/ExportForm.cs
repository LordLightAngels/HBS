using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            DateTime start = main.GetStartDate();
            DateTime end = main.GetEndDate();
            String startString = start.ToString("yyyy-MM-dd hh:mm:ss");
            String endString = end.ToString("yyyy-MM-dd hh:mm:ss");
            String idSensor = main.getSensor();

            String query;
            String whereClause = idSensor;

            whereClause = (idSensor == "") ? "1" : whereClause = "sensor.id = " + idSensor;

            query = "SELECT  sensor.*, data.*" +
                    "FROM sensor INNER JOIN data " +
                    "ON data.sensor LIKE sensor.id " +
                    "WHERE " + whereClause + " " +
                    "AND data_date BETWEEN '" + startString + "' AND '" + endString + "' " +
                    "ORDER BY data_date DESC, sensor ";

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

        private void ExportDataPDF(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.AddAuthor("Micke Blomquist");
            document.AddCreator("Sample application using iTextSharp");
            document.AddKeywords("PDF tutorial education");
            document.AddSubject("Document subject - Describing the steps creating a PDF document");
            document.AddTitle("The document title - PDF creation using iTextSharp");
            // Open the document to enable you to write to the document
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner
            document.Add(new Paragraph("Hello World!"));
            // Close the document
            document.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity
            fs.Close();
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
                    if (mrbExcel.Checked) ExportDataCSV(saveFile.FileName);
                    if (mrbPDF.Checked) ExportDataPDF(saveFile.FileName);
                }
            }

            if (mcbEnvoiDoc.Checked) SendMail();
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