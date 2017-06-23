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
    public partial class SynthesisForm : Form
    {
        public SynthesisForm()
        {
            InitializeComponent();
        }

        public void DisplaySynthesis()
        {
            String query = "SELECT data.*, sensor.* FROM data INNER JOIN sensor " +
                "ON data.sensor = sensor.id ORDER BY data.data_date DESC";

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
                int row = dgSynthesis.Rows.Add(new object[] {
                        line["uid"],
                        line["data_date"],
                        line["temperature"],
                        line["humidity"],
                        line["uid"],
                        Properties.Resources.pbelle
                });
                dgSynthesis.Rows[row].Tag = line["id"];
            }

            //dgSynthesis.

        }
    }
}
