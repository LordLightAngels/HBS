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

            synthesis.Show();

            Dictionary<String, String> parameters = new Dictionary<String, String>();

            cbSensor.DisplayMember = "Text";
            cbSensor.ValueMember = "Name";

            List<Dictionary<String, String>> lines = new List<Dictionary<string, string>>();

            try
            {
                lines = DBInteractor.Select("SELECT id,label FROM sensor", parameters);
            } catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            foreach (Dictionary<String, String> line in lines)
            {
                MenuItem item = new MenuItem();
                item.Text = line["label"];
                item.Name = line["id"];
                cbSensor.Items.Add(item);
            }

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

        /// <summary>
        /// retourne la valeur du capteur sélectionné
        /// </summary>
        /// <returns></returns>
        public String getSensor()
        {
            /*if (cbSensor.SelectedValue == null)
            {
                return "";
            }
            else
            {
                return cbSensor.SelectedValue.ToString();
            }*/
            //return cbSensor.SelectedItem == null ? "" : cbSensor.SelectedItem.ToString();
            if (cbSensor.SelectedItem == null) return "";
            MenuItem item = (MenuItem)cbSensor.SelectedItem;
            return item.Name;
        }
        

        /// <summary>
        /// cache tous les formulaires
        /// </summary>
        private void HideForms()
        {
            foreach (Control form in pnlMain.Controls)
                form.Hide();
        }


        //méthode perso Domitille
        /*private void loadSensor(object sender, EventArgs e)
        {
            string sql = "SELECT id, label FROM sensor";
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=sensorboard;UID=root;PASSWORD=;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sensorList.Add(Convert.ToInt32(reader["id"]), reader["label"].ToString());
                }
            }
            foreach(KeyValuePair<int, String>sensor in sensorList)
            {
                Console.WriteLine(sensor.Key.ToString() + " = " + sensor.Value);
            }


        }*/
    }
}
