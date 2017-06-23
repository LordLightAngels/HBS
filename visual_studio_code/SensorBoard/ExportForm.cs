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

        public void ExportDataCSV()
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
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            DBInteractor db = new DBInteractor();
            List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();

            try
            {
                db.Connect();
                resultset = db.Select(query, parameters);
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
                MainForm mf = (MainForm)this.ParentForm;

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "csv";
                String name = Function.slugify(mf.getSensorName());
                name = String.IsNullOrEmpty(name) ? "Tout-capteur" : name;
                savefile.FileName = name;
                

                if (savefile.ShowDialog() == DialogResult.OK)
                { 
                    File.WriteAllText(savefile.FileName, finalRes.ToString());
                    this.filePath = savefile.FileName;
                }

                if (mcbOuvrir.Checked)
                {
                    Process.Start(savefile.FileName);
                }

                if (mcbEnvoiPDF.Checked)
                {
                    try
                    {
                        SendMail();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
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
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                String destAddress = tfInputEmail.Text;
                if (destAddress == "saisir adresse mail") throw new Exception("Veuillez saisir l'adresse d'un destinataire !"); 

                mail.From = new MailAddress("cobralerte@gmail.com");
                mail.To.Add(destAddress);
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";
                mail.Attachments.Add(new Attachment(filePath));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cobralerte", "alerteCOBRA-Pi3B");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail envoyé avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mrbExport_Click(object sender, EventArgs e)
        {
            if (mrbExcel.Checked) ExportDataCSV();
            if (mcbEnvoiPDF.Checked) SendMail();

        }
    }
}
