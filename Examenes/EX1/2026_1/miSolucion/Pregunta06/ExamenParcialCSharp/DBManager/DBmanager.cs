using System;
using MySql.Data.MySqlClient;

namespace DBManager
{
    public class DBmanager
    {
        private string? cadenaConexion;
        private static DBmanager? instance;

        public void Inicializar(string? cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        public static DBmanager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBmanager();
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

