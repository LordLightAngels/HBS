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
        //Variable pour l'update si bouton modifier est sélectionné
        String idSensor;

        public SensorForm()
        {
            InitializeComponent();
        }

        public void DisplaySensor()
        {
            this.dgvSensor.Rows.Clear();

            List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();

            try
            {
                resultset = DBInteractor.QuickSelect("SELECT * FROM sensor");
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
                        Properties.Resources.pencil3,
                        Properties.Resources.pbelle
                });
                dgvSensor.Rows[row].Tag = line["id"];
            }

        }

        public void refreshSensor()
        {
            dgvSensor.Rows.Clear();

            List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();

            try
            {
                resultset = DBInteractor.QuickSelect("SELECT * FROM sensor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            foreach (Dictionary<String, String> line in resultset)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSensor, new object[] {
                    line["uid"],
                    line["label"],
                    line["webservice"],
                    Properties.Resources.pencil3,
                    Properties.Resources.pbelle
                });
                row.Tag = line["id"];

                dgvSensor.Rows.Add(row);
            }
        }

        private void mrbSensorRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = this.ParentForm;
                MainForm main = (MainForm)form;

                Dictionary<String, String> parameters = new Dictionary<String, String>();
                parameters["@label"] = msltfLabelSensor.Text;
                parameters["@webservice"] = msltfWebServiceSensor.Text;
                parameters["@uid"] = msltfUIDSensor.Text;
                if (idSensor!= null)
                {
                    DBInteractor.QuickExecute("UPDATE sensor SET label = '" + msltfLabelSensor.Text + "', webservice = '" 
                        + msltfWebServiceSensor.Text + "', uid = '" + msltfUIDSensor.Text + "' WHERE id = " + idSensor);
                    idSensor = null;

                }
                else
                {
                    DBInteractor.QuickExecute("INSERT INTO sensor (label,webservice,uid) VALUE(@label,@webservice,@uid)", parameters);
                }
                main.refreshSensorMain();
                msltfLabelSensor.Text = "";
                msltfWebServiceSensor.Text = "";
                msltfUIDSensor.Text = "";
                refreshSensor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                DialogResult result = MessageBox.Show("Etes vous sur de vouloir supprimer ce capteur ? Toutes les données y étant attaché vont être aussi supprimé ! "
                , "Confirmation de suppresion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                String queryData = "DELETE FROM data WHERE sensor = " + id;
                String querySensor = "DELETE FROM sensor WHERE id = " + id;
                DBInteractor.QuickExecute(queryData);
                DBInteractor.QuickExecute(querySensor);
                refreshSensor();
                main.refreshSensorMain();
                DisplaySensor();
            }
            if (e.ColumnIndex == 3)
            {
                int row = e.RowIndex;
                object object_id = dgvSensor.Rows[row].Tag;
                String id = (String)object_id;

                List<Dictionary<String, String>> resultSensor = DBInteractor.QuickSelect("SELECT * FROM sensor WHERE id = " + id);
                msltfLabelSensor.Text = resultSensor[0]["label"];
                msltfWebServiceSensor.Text = resultSensor[0]["webservice"];
                msltfUIDSensor.Text = resultSensor[0]["uid"];
                idSensor = resultSensor[0]["id"];
            }
        }
    }
}
