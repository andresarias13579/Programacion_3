using System;
using MySql.Data.MySqlClient;

namespace SpotipucpDBManager
{
    public class DBManager
    {
        private string? cadenaConexion;
        private static DBManager? instance;

        public void Inicializar(string? cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBManager();
                }
                return instance;
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                return con;
            }
        }
    }
}

