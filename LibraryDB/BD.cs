using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibraryDB
{
    public class BD
    {
        private static MySqlConnection cnx;

        public static void initConnexion()
        {            
            String server = "10.1.139.236";
            String login = "c2";
            String passwd = "mdp";
            String BD = "basec2";
            string connexion = $"SERVER={server};DATABASE={BD};UID={login};PASSWORD={passwd};";

            cnx = new MySqlConnection(connexion);

            try
            {
                cnx.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        /// <summary>
        /// sous-programme qui renvoie dans une liste de chaine de caractères le nom de toute les lignes
        /// </summary>
        /// <returns>une liste de chaine de caractéres représentant le nom des lignes de bus</returns>
        public static List<String> getNomLigne()
        {
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select nomLigne from Ligne";
            dr = cmd.ExecuteReader(); 
            List<String> test = new List<String>();
            while (dr.Read())
            {
                test.Add(Convert.ToString(dr["nomLigne"]));
            }
            return test;
        }

        public static void closeConnexion()
        {
            try
            {
                cnx.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
