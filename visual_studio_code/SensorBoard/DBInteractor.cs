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

        public void Execute(String query, Dictionary<String, String> parameters)
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
            return results;
        }

        public List<Dictionary<String, String>> Select(String query)
        {
            Dictionary<String, String> param = new Dictionary<string, string>();
            return Select(query, param);
        }
        //à faire partout ailleurs que dans les boucles
        public void quickExecute(String query, Dictionary<String, String> parameters)
        {
            DBInteractor db = new DBInteractor();
            db.Connect();
            db.Execute(query, parameters);
            db.Disconnect();
        }

        public static List<Dictionary<String, String>> QuickSelect(String query, Dictionary<String, String> parameters)
        {
            DBInteractor db = new DBInteractor();
            db.Connect();
            List<Dictionary<String, String>> resultSet = db.Select(query, parameters);
            db.Disconnect();
            return resultSet;

        }

        public static List<Dictionary<String, String>> QuickSelect(String query)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            return DBInteractor.QuickSelect(query, parameters);
        }


    }
}
