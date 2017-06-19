using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorBoard
{
    class DBInteractor
    {
        MySqlConnection connection;

        public void Connect()
        {
            connection = new MySqlConnection("SERVER=" + Properties.Resources.DATABASE_HOST
            + ";DATABASE=" + Properties.Resources.DATABASE_NAME
             + ";UID=" + Properties.Resources.DATABASE_LOGIN
             + ";PASSWORD=" + Properties.Resources.DATABASE_PASSWORD + ";");
            connection.Open();
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public void Insert(String query, Dictionary<String, String> parameters)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            foreach (KeyValuePair<String, String> kvp in parameters)
            {
                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
            }

            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Effectue une requete type select et retourne une liste de dictionnaires de résultats
        /// </summary>
        /// <param name="query">Requête SQL</param>
        /// <param name="parameters">Valeurs de la requête</param>
        /// <returns></returns>
        public List<Dictionary<String, String>> Select(String query, Dictionary<String, String> parameters)
        {

            List<Dictionary<String, String>> results = new List<Dictionary<String, String>>();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            foreach (KeyValuePair<String, String> kvp in parameters)
            {
                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
            }

            MySqlDataReader resultset = command.ExecuteReader();

            while (resultset.Read())
            {
                Dictionary<String, String> line = new Dictionary<String, String>();

                for (int i = 0; i < resultset.FieldCount; i++)
                {
                    line[resultset.GetName(i)] = resultset.GetValue(i).ToString();
                }
                results.Add(line);
            }

            connection.Close();
            return results;
        }

        public static void quickInsert(String query, Dictionary<String, String> parameters)
        {
            DBInteractor db = new DBInteractor();
            db.Connect();

        }

    }
}
