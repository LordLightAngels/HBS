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

            foreach (Dictionary<String, String> line in resultset)
            {
                int row = dgBase.Rows.Add(new object[] {
                        line["label"],
                        line["data_date"].Split()[0],
                        line["data_date"].Split()[1],
                        line["temperature"],
                        line["humidity"],
                        line["uid"],
                        Properties.Resources.pbelle
                });
                dgBase.Rows[row].Tag = line["id"];
            }

            /*DataGridViewRow row = new DataGridViewRow();

            MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1;DATABASE=sensorboard;UID=root;PASSWORD=;");
            connection.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT * FROM data", connection);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgBase.DataSource = ds.Tables[0];
            connection.Close();*/

        }



        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int row = e.RowIndex;
                object object_id = dgBase.Rows[row].Tag;
                String id = (String)object_id;

                String query = "DELETE FROM data WHERE id = " + id;
                Dictionary<String, String> parameters = new Dictionary<string, string>();
                DBInteractor db = new DBInteractor();
                db.quickExecute(query, parameters);

                DisplayData();
            }
            }
        }
}