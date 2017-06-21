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

        public void refreshSensor()
        {
            dgvSensor.Rows.Clear();
            DBInteractor db = new DBInteractor();
            db.Connect();
            foreach (Dictionary<String, String> line in db.Select("SELECT id,label,webservice,uid FROM sensor"))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSensor, new object[] {
                    line["label"],
                    line["webservice"],
                    line["uid"],
                    Properties.Resources.pencil,
                    Properties.Resources.pbelle
                });
                row.Tag = line["id"];

                dgvSensor.Rows.Add(row);
            }
        }

        private void mrbSensorCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = this.ParentForm;
                MainForm main = (MainForm)form;

                DBInteractor db = new DBInteractor();
                db.Connect();

                Dictionary<String, String> parameters = new Dictionary<String, String>();
                parameters["@label"] = msltfLabelSensor.Text;
                parameters["@webservice"] = msltfWebServiceSensor.Text;
                parameters["@uid"] = msltfUIDSensor.Text;
                db.quickExecute("INSERT INTO sensor (label,webservice,uid) VALUE(@label,@webservice,@uid)", parameters);
                refreshSensor();
                main.refreshSensorMain();
                msltfLabelSensor.Text = "";
                msltfWebServiceSensor.Text = "";
                msltfUIDSensor.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout "+ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSensor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Form form = this.ParentForm;
                MainForm main = (MainForm)form;

                int row = e.RowIndex;
                object object_id = dgvSensor.Rows[row].Tag;
                String id = (String)object_id;

                DialogResult result = MessageBox.Show("Etes vous sur de vouloir supprimer les entrees", "Confirmation de suppresion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;

                String query = "DELETE FROM sensor WHERE id = " + id;
                Dictionary<String, String> parameters = new Dictionary<string, string>();
                DBInteractor db = new DBInteractor();
                db.quickExecute(query, parameters);
                refreshSensor();

                main.refreshSensorMain();
                DisplaySensor();
            }
        }
    }
}
