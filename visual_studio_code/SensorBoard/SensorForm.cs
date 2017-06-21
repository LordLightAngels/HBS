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
    public partial class SensorForm : Form
    {
        public SensorForm()
        {
            InitializeComponent();
        }

        public void DisplaySensor()
        {
            this.dgvSensor.Rows.Clear();

            String query = "SELECT * FROM sensor";
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

            foreach (Dictionary<String, String> line in resultset)
            {
                int row = dgvSensor.Rows.Add(new object[] {
                        line["uid"],
                        line["label"],
                        line["webservice"],
                        Properties.Resources.pencil,
                        Properties.Resources.pbelle
                });
                dgvSensor.Rows[row].Tag = line["id"];
            }

        }

        private void mrbSensorCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
