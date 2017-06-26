﻿using System;
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
            String query;
            String uidSensor;

            lUID.Text = "UID du capteur";
            ldtStart.Text = "Date et heure de\r\nl'import le plus ancien";
            ldtEnd.Text = "Date et heure de\r\nl'import le plus récent";
            lNbr.Text = "Nombre total d'import\r\nsur cette période";

            tfUID.Text = "";
            tfdtStart.Text = "";
            tfdtEnd.Text = "";
            tfNbr.Text = "";

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

                if (lenResultset == 0)
                {
                    uidSensor = DBInteractor.QuickSelect("SELECT uid FROM sensor WHERE sensor.id = " + idSensor)[0]["uid"].ToString();
                }
                else
                {
                    uidSensor = resultset[0]["uid"];
                    // requête avec ORDER BY ASC --> 1ere ligne du resultset comprend la data la plus ancienne
                    dtStart = resultset[0]["data_date"].ToString();
                    // requête avec ORDER BY ASC --> dernière ligne du resultset comprend la data la plus récente
                    dtEnd = resultset[lenResultset - 1]["data_date"].ToString();
                }

                tfUID.Text = uidSensor;
                tfdtStart.Text = dtStart;
                tfdtEnd.Text = dtEnd;
                tfNbr.Text = lenResultset.ToString();

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

            lUID.Text = "UID du capteur";
            ldtStart.Text = "Date et heure de\r\nl'import le plus ancien";
            ldtEnd.Text = "Date et heure de\r\nl'import le plus récent";
            lNbr.Text = "Nombre total d'import\r\nsur cette période";

            tfUID.Text = "";
            tfdtStart.Text = "";
            tfdtEnd.Text = "";
            tfNbr.Text = "";

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

                chTemp.Series.Add("Temperatures");

                foreach (Dictionary<String, String> line in resultset)
                {
                    chTemp.Series["Temperatures"].Points.AddXY(line["data_date"], line["temperature"]);
                
                }





            }
        }

    }
}

