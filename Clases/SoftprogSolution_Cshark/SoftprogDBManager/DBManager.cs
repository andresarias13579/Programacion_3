using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftprogDBManager
{
    public class DBManager
    {
        private static DBManager? instance;

        public static DBManager Instance
        {
            get
            {
                if (instance == null) instance = new DBManager();
                return instance;
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                String cadena = "Server=softprog-p3.cc5sy5wyeisw.us-east-1.rds.amazonaws.com;" +
                    "Port=3306;" + "Database=softprogP3;" + "User ID=admin;" + "Password=20234902Aa;";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                return con;
            }
        }
    }
}
