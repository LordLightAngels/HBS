using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Dictionary<int, String> sensorList = new Dictionary<int, string>();

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

            export = new ExportForm();
            export.TopLevel = false;
            export.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(export);


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

            synthesis.Show();

            Dictionary<String, String> parameters = new Dictionary<String, String>();

            cbSensor.DisplayMember = "Text";
            cbSensor.ValueMember = "Name";

            List<Dictionary<String, String>> lines = new List<Dictionary<string, string>>();

            DBInteractor db = new DBInteractor();
            MySqlConnection connection = new MySqlConnection();
            

            try
            {
                db.Connect();
                lines = db.Select("SELECT id,label FROM sensor", parameters);
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
                cbSensor.Items.Add(item);
            }

            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //DateTime.Parse("01/01" + DateTime.Now.Year);
            dtpEnd.Value = DateTime.Now.AddDays(1);
        

        }

        internal string getSensorName()
        {
            if (cbSensor.SelectedItem == null) return "";
            MenuItem item = (MenuItem)cbSensor.SelectedItem;
            return item.Name;
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
            export.Show();
        }

        private void loadSynthesis(object sender, EventArgs e)
        {
            HideForms();
            synthesis.Show();
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
            data.DisplayData();
        }

        //if (dtpStart.Value > dtpEnd.Value) MessageBox.Show("Rectifiez votre sélection de dates");
            //data.DisplayData();

        public void refreshSensorMain()
        {
            cbSensor.Items.Clear();
            Dictionary<String, String> parameters = new Dictionary<String, String>();

            cbSensor.DisplayMember = "Text";
            cbSensor.ValueMember = "Name";

            List<Dictionary<String, String>> lines = new List<Dictionary<string, string>>();

            DBInteractor db = new DBInteractor();
            MySqlConnection connection = new MySqlConnection();


            try
            {
                db.Connect();
                lines = db.Select("SELECT id,label FROM sensor", parameters);
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
                cbSensor.Items.Add(item);
            }
        }
    }
}
