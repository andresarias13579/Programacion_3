using System;
using MySql.Data.MySqlClient;

namespace SpotipucpDBManager
{
    public class DBManager
    {
        private static DBManager? instance;

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

            }
        }
    }
}
