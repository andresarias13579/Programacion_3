using MySql.Data.MySqlClient;
using SpotipucpDBManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftProgDBManager
{
    public class TransactionContext
    {
        private static ThreadLocal<MySqlConnection?>
            connectionHolder =
            new ThreadLocal<MySqlConnection?>();

        private static ThreadLocal<MySqlTransaction?>
            transactionHolder =
            new ThreadLocal<MySqlTransaction?>();

        public static MySqlConnection Connection
        {
            get
            {
                MySqlConnection? con = connectionHolder.Value;
                if (con == null ||
                    con.State != System.Data.ConnectionState.Open)
                {
                    con = DBManager.Instance.Connection;
                    connectionHolder.Value = con;
                }
                return con;
            }
        }

        public static MySqlTransaction? Transaction
        {
            get
            {
                return transactionHolder.Value;
            }
        }

        public static void BeginTransaction()
        {
            if (transactionHolder.Value == null)
                transactionHolder.Value = Connection.BeginTransaction();
        }

        public static void Commit()
        {
            if (transactionHolder.Value != null)
                transactionHolder.Value.Commit();
        }

        public static void RollBack()
        {
            if (transactionHolder.Value != null)
                transactionHolder.Value.Rollback();
        }

        public static void Close()
        {
            if (transactionHolder.Value != null)
                transactionHolder.Value.Dispose();

            if (transactionHolder.Value != null)
            {
                connectionHolder.Value.Close();
                connectionHolder.Value.Dispose();
            }

            transactionHolder.Value = null;
            connectionHolder.Value = null;
        }
    }
}
