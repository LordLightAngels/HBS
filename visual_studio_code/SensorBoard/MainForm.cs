using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorBoard
{
    public partial class MainForm : MaterialForm

    {
        ImportForm import;
        ExportForm export;
        SynthesisForm synthesis;
        DataForm data;
        SensorForm sensor;
        Timer aTimer;
        Dictionary<int, String> sensorList = new Dictionary<int, string>();
        private readonly object serializer;

        public MainForm()
        {
            InitializeComponent();


            //Instantiation du formulaire enfant
            import = new ImportForm();
            //Définition en formulaire inclus
            import.TopLevel = false;
            //Agrandissement à la taille du panel conteneur
            import.Dock = DockStyle.Fill;
            //Ajout du formulaire au panel principal
            pnlMain.Controls.Add(import);

            synthesis = new SynthesisForm();
            synthesis.TopLevel = false;
            synthesis.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(synthesis);

            data = new DataForm();
            data.TopLevel = false;
            data.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(data);

            sensor = new SensorForm();
            sensor.TopLevel = false;
            sensor.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(sensor);

            refreshSensorMain();

            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpEnd.Value = DateTime.Now.AddDays(1);

            HideForms();
            synthesis.Show();
            synthesis.DisplaySynthesis();
            synthesis.chTemp_Load();

        }

        internal string getSensorName()
        {
            if (cbSensor.SelectedItem == null) return "";
            MenuItem item = (MenuItem)cbSensor.SelectedItem;
            return item.Text;
        }

        private void loadImport(object sender, EventArgs e)
        {
            HideForms();
            //Affichage du formulaire
            import.Show();
        }

        private void loadExport(object sender, EventArgs e)
        {
            HideForms();
            export = new ExportForm();
            export.TopLevel = false;
            export.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(export);

            export.Show();
        }

        private void loadSynthesis(object sender, EventArgs e)
        {
            HideForms();
            synthesis.Show();
            synthesis.DisplaySynthesis();
            synthesis.chTemp_Load();
        }

        private void loadData(object sender, EventArgs e)
        {
            HideForms();
            data.Show();
            data.DisplayData();
        }

        private void loadSensor(object sender, EventArgs e)
        {
            HideForms();
            sensor.Show();
            sensor.DisplaySensor();
        }

        /// <summary>
        /// retourne la valeur du capteur sélectionné
        /// </summary>
        /// <returns></returns>
        public String getSensor()
        {
            if (cbSensor.SelectedItem == null) return "";
            MenuItem item = (MenuItem)cbSensor.SelectedItem;
            return item.Name;
        }

        public DateTime GetStartDate()
        {
            return dtpStart.Value;
        }

        public DateTime GetEndDate()
        {
            return dtpEnd.Value;
        }

        /// <summary>
        /// cache tous les formulaires
        /// </summary>
        private void HideForms()
        {
            foreach (Control form in pnlMain.Controls)
                form.Hide();
        }

        private void cbSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value) MessageBox.Show("Rectifiez votre sélection de dates");
            if (cbSensor.SelectedItem != null)
            {
                
                //Si on caste pas en MenuItem, pas accès à propriété Tag
                MenuItem item = (MenuItem)cbSensor.SelectedItem;
                String webservice = (String)item.Tag;
                if((webservice != "") && (webservice != null))
                {
                    MessageBox.Show(webservice);
                    aTimer.Tick += new EventHandler(GetDataWebService);
                }
            }
            data.DisplayData();
            synthesis.DisplaySynthesis();
            synthesis.chTemp_Load();
        }

        private void GetDataWebService(object sender, EventArgs e)
        {
            aTimer = new Timer();
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            MenuItem item = (MenuItem)cbSensor.SelectedItem;
            String webservice = (String)item.Tag;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webservice);
            request.UserAgent = "toto";
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            MessageBox.Show("Response stream received.");
            
            

            JObject obj = JObject.Parse(readStream.ReadToEnd());
            MessageBox.Show(obj.ToString());
            String dataDate = (String)obj["date"];
            String humidity = (String)obj["humidity"];
            String temperature = (String)obj["temperature"];

            String query = "INSERT INTO data(data_date,temperature,humidity,import_date,sensor) " +
                    "VALUES(@data_date, @temperature, @humidity, @import_date, @sensor)";
            Dictionary < String, String > parameters = new Dictionary<String, String>(){
                                            {"@data_date", dataDate},
                                            {"@temperature", temperature },
                                            {"@humidity", humidity },
                                            {"@import_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                                            {"@sensor", item.Name },
                                };

            try
            {
                DBInteractor.QuickExecute(query,parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            MessageBox.Show("L'insertion de vos données a été effectuée avec succès");

            response.Close();
            readStream.Close();
            aTimer.Stop();

        }


        

        //if (dtpStart.Value > dtpEnd.Value) MessageBox.Show("Rectifiez votre sélection de dates");
        //data.DisplayData();

        public void refreshSensorMain()
        {
            cbSensor.Items.Clear();
            cbSensor.DisplayMember = "Text";
            cbSensor.ValueMember = "Name";
            List<Dictionary<String, String>> lines = new List<Dictionary<string, string>>();

            try
            {
                 lines = DBInteractor.QuickSelect("SELECT id,label, webservice FROM sensor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            MenuItem empty_item = new MenuItem();
            empty_item.Text = "";
            empty_item.Name = "";
            cbSensor.Items.Add(empty_item);

            foreach (Dictionary<String, String> line in lines)
            {
                MenuItem item = new MenuItem();
                item.Text = line["label"];
                item.Name = line["id"];
                item.Tag = line["webservice"];
                cbSensor.Items.Add(item);
            }
        }
    }
}
