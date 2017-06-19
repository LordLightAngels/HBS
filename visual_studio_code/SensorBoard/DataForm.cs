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

            Dictionary<String, String> parameters = new Dictionary<String, String>();
            List<Dictionary<String, String>> lines = new List<Dictionary<string, string>>();
            DBInteractor db = new DBInteractor();
            MySqlConnection connection = new MySqlConnection();
            //dgBase.Rows.Add(new object[] { "1", "2", "3", "4", "5", Properties.Resources.pbelle });
            try
            {
                db.Connect();
                lines = db.Select("SELECT data.*, sensor.* FROM data INNER JOIN sensor ON data.sensor = sensor.id", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            foreach (Dictionary<String, String> line in lines)
            {
                dgBase.Rows.Add(new object[] {
                                line["label"],
                                line["import_date"],
                                line["humidity"],
                                line["temperature"],
                                line["data_date"],
                                Properties.Resources.pbelle });      
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

        private void dgBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
