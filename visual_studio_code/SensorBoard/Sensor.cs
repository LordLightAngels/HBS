using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorBoard
{
    class Sensor 
    {
        String idSensor;
        MainForm main = new MainForm();

        public static List<Dictionary<String, String>> getAllSensors()
        {
            Sensor s = new Sensor();
            DateTime start = s.main.GetStartDate();
            DateTime end = s.main.GetEndDate();
            String startString = start.ToString("yyyy-MM-dd HH:mm:ss");
            String endString = end.ToString("yyyy-MM-dd HH:mm:ss");
            String idSensor = s.main.getSensor();

            String query;
            String whereClause = idSensor;

            whereClause = (idSensor == "") ? "1" : whereClause = "sensor.id = " + idSensor;

            query = "SELECT  sensor.*, data.*" +
                    "FROM sensor INNER JOIN data " +
                    "ON data.sensor LIKE sensor.id " +
                    "WHERE " + whereClause + " " +
                    "AND data_date BETWEEN '" + startString + "' AND '" + endString + "' " +
                    "ORDER BY data_date DESC, sensor ";

            List<Dictionary<String, String>> resultset = new List<Dictionary<string, string>>();

            try
            {
                return resultset = DBInteractor.QuickSelect(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                    ex.Message + "\n\r" + ex.StackTrace);
            }

            return resultset;
        }
    }
}
