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
            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            DateTime start = main.GetStartDate();
            DateTime end = main.GetEndDate();
            String startString = start.ToString("yyyy-MM-dd hh:mm:ss");
            String endString = end.ToString("yyyy-MM-dd hh:mm:ss");
            String idSensor = main.getSensor();
            String labelSensor;
            String query;
            String queryTemp;
            String queryHumid;
            String uidSensor;

            tfUID.Text = tfLabel.Text = tfdtStart.Text = tfdtEnd.Text = tfNbr.Text = mlMinTempData.Text = mlMaxTempData.Text = mlMedTempData.Text = mlMinHumidData.Text = mlMaxHumidData.Text = mlMedHumidData.Text = "";

            if (idSensor != "")
            {
                query = "SELECT data.*, sensor.*" +
                        "FROM data INNER JOIN sensor " +
                        "ON data.sensor = sensor.id " +
                        "WHERE sensor.id = " + idSensor + " " +
                        "AND (data_date BETWEEN '" + startString + "' AND '" + endString + "') " +
                        "ORDER BY data_date ASC";

                queryTemp = "SELECT MIN(temperature) AS Tmin, MAX(temperature) AS Tmax, AVG(temperature) AS Tmed from data INNER JOIN sensor ON data.sensor = sensor.id WHERE sensor.id = " + idSensor;
                queryHumid = "SELECT MIN(humidity) AS Hmin, MAX(humidity) AS Hmax, AVG(humidity) AS Hmed from data INNER JOIN sensor ON data.sensor = sensor.id WHERE sensor.id = " + idSensor;

                List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();
                List<Dictionary<String, String>> resultTemp = new List<Dictionary<string, string>>();
                List<Dictionary<String, String>> resultHumid = new List<Dictionary<string, string>>();
                String dtStart = "";
                String dtEnd = "";
                Decimal tempMin;
                Decimal tempMax;
                Decimal tempMed;
                Decimal humidMin;
                Decimal humidMax;
                Decimal humidMed;
                int lenResultset;

                try
                {
                    resultset = DBInteractor.QuickSelect(query);
                    resultTemp = DBInteractor.QuickSelect(queryTemp);
                    resultHumid = DBInteractor.QuickSelect(queryHumid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                        ex.Message + "\n\r" + ex.StackTrace);
                }

                lenResultset = resultset.Count;

                //Si pas de data liées au capteur alors renvoi juste l'uid  et le libellé du capteur sélectionné
                if (lenResultset == 0)
                {
                    uidSensor = DBInteractor.QuickSelect("SELECT uid FROM sensor WHERE sensor.id = " + idSensor)[0]["uid"].ToString();
                    labelSensor = DBInteractor.QuickSelect("SELECT label FROM sensor WHERE sensor.id = " + idSensor)[0]["label"].ToString();
                    tempMin = tempMax = tempMed = humidMin = humidMax = humidMed = 0;
                }
                else
                {
                    uidSensor = resultset[0]["uid"];
                    // requête avec ORDER BY ASC --> 1ere ligne du resultset comprend la data la plus ancienne
                    labelSensor = resultset[0]["label"];
                    dtStart = resultset[0]["data_date"].ToString();
                    // requête avec ORDER BY ASC --> dernière ligne du resultset comprend la data la plus récente
                    dtEnd = resultset[lenResultset - 1]["data_date"].ToString();
                    tempMin = decimal.Parse(resultTemp[0]["Tmin"]);
                    tempMax = decimal.Parse(resultTemp[0]["Tmax"]);
                    tempMed = decimal.Parse(resultTemp[0]["Tmed"]);
                    humidMin = decimal.Parse(resultHumid[0]["Hmin"]);
                    humidMax = decimal.Parse(resultHumid[0]["Hmax"]);
                    humidMed = decimal.Parse(resultHumid[0]["Hmed"]);
                }

                tfUID.Text = uidSensor;
                tfLabel.Text = labelSensor;
                tfdtStart.Text = dtStart;
                tfdtEnd.Text = dtEnd;
                tfNbr.Text = lenResultset.ToString();
                mlMinTempData.Text = tempMin + "°C";
                mlMaxTempData.Text = tempMax + "°C";
                mlMedTempData.Text = Math.Round(tempMed,1) + "°C";
                mlMinHumidData.Text = humidMin + "%";
                mlMaxHumidData.Text = humidMax + "%";
                mlMedHumidData.Text = Math.Round(humidMed,1) + "%";

                chTemp_Load();

            }
        }

        public void chTemp_Load()
        {
            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            DateTime start = main.GetStartDate();
            DateTime end = main.GetEndDate();
            String startString = start.ToString("yyyy-MM-dd hh:mm:ss");
            String endString = end.ToString("yyyy-MM-dd hh:mm:ss");
            String idSensor = main.getSensor();
            String query;
            String uidSensor;


            if (idSensor != "")
            {
                query = "SELECT data.*, sensor.*" +
                        "FROM data INNER JOIN sensor " +
                        "ON data.sensor = sensor.id " +
                        "WHERE sensor.id = " + idSensor + " " +
                        "AND (data_date BETWEEN '" + startString + "' AND '" + endString + "') " +
                        "ORDER BY data_date ASC";

                List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();
                String dtStart = "";
                String dtEnd = "";
                int lenResultset;

                try
                {
                    resultset = DBInteractor.QuickSelect(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                        ex.Message + "\n\r" + ex.StackTrace);
                }

                lenResultset = resultset.Count;

                chTemp.Series["Temperatures"].Points.Clear();
                chTemp.Series["Humidité"].Points.Clear();

                foreach (Dictionary<String, String> line in resultset)
                {
                    chTemp.Series["Temperatures"].Points.AddXY(line["data_date"], line["temperature"]);
                    chTemp.Series["Humidité"].Points.AddXY(line["data_date"], line["humidity"]);


                }






            }
        }

    }
}

