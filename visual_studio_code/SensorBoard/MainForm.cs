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
            return cbSensor.SelectedItem == null ? "" : cbSensor.SelectedItem.ToString();
        }
        

        /// <summary>
        /// cache tous les formulaires
        /// </summary>
        private void HideForms()
        {
            foreach (Control form in pnlMain.Controls)
                form.Hide();
        }

        private void loadSensor(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=sensorboard;UID=root;PASSWORD=;");


        }
    }
}
