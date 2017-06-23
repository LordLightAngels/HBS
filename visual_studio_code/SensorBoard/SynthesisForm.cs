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
            String idSensor = main.getSensor();
            String query;
            String uidSensor;

            lUID.Text = "ID du capteur";
            ldtStart.Text = "Date et heure de\r\nl'import le plus ancien";
            ldtEnd.Text = "Date et heure de\r\nl'import le plus récent";
            lNbr.Text = "Nombre total d'import\r\nsur cette période";

            tfUID.Text = "";
            tfdtStart.Text = "";
            tfdtEnd.Text = "";
            tfNbr.Text = "";

            if (idSensor != "")
            {
                query = "SELECT  sensor.*, data.*" +
                        "FROM sensor INNER JOIN data " +
                        "ON data.sensor = sensor.id " +
                        "WHERE sensor.id = " + idSensor + " " +
                        "ORDER BY data_date ASC";

                List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();
                String dtStart = "0";
                String dtEnd = "0";
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

                uidSensor = resultset[0]["uid"];
                lenResultset = resultset.Count;

                if (lenResultset != 0)
                {
                    dtStart = resultset[0]["data_date"].ToString();
                    dtEnd = resultset[lenResultset - 1]["data_date"].ToString();
                }

                tfUID.Text = uidSensor;
                tfdtStart.Text = dtStart;
                tfdtEnd.Text = dtEnd;
                tfNbr.Text = lenResultset.ToString();

                

            }
        }
    }
}

