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
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            this.dgBase.Rows.Clear();

            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            DateTime start = main.GetStartDate();
            DateTime end = main.GetEndDate();
            String startString = start.ToString("yyyy-MM-dd HH:mm:ss");
            String endString = end.ToString("yyyy-MM-dd HH:mm:ss");
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

            foreach (Dictionary<String, String> line in resultset)
            {
                int row = dgBase.Rows.Add(new object[] {
                        line["label"],
                        line["data_date"],
                        line["temperature"],
                        line["humidity"],
                        line["uid"],
                        Properties.Resources.pbelle
                });
                dgBase.Rows[row].Tag = line["id"];
            }

        }

        private void dgBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)

            {
                int row = e.RowIndex;
                object object_id = dgBase.Rows[row].Tag;
                String id = (String)object_id;

                DialogResult result = MessageBox.Show("Etes vous sur de vouloir supprimer les entrees", "Confirmation de suppresion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;

                String query = "DELETE FROM data WHERE id = " + id;
                DBInteractor.QuickExecute(query);

                DisplayData();
            }

        }

        //List<String> errorSupp = new List<string> { };
        int errorCpt = 0;

        private void dgBase_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                object object_id = e.Row.Tag;
                String id = (String)object_id;
                String query = "DELETE FROM data WHERE id = " + id;
                //Dictionary<String, String> parameters = new Dictionary<string, string>();
                //DBInteractor db = new DBInteractor();
                DBInteractor.QuickExecute(query);
            }
            catch (Exception)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.Red;
                e.Row.Cells[0].Style = style;
                //MessageBox.Show("Erreur lors de la suppression :" + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //errorSupp.Add(ex.Message);
                //int sizeOfList = errorSupp.Count;
                errorCpt++;
                lblDatas.Text = "Le nombre d'erreur est : " + errorCpt;
                e.Cancel = true;
            }
        }

        private void dgvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            DialogResult result = MessageBox.Show("Etes vous sur de vouloir supprimer les entrees", "Confirmation de suppresion", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) e.Handled = true;
            lblDatas.Text = "Donnees existantes";
            errorCpt = 0;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.White;
            foreach (DataGridViewRow row in dgBase.Rows)
            {
                row.DefaultCellStyle = style;
            }
        }
    }

}