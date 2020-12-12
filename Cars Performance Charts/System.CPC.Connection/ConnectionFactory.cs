/*
 * Database connection class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

/*
 * CPC / Connection / ConnectionFactory
 * @author MRX
 * Version : 1.0.0
 */

namespace System.CPC.Connection
{
    public static class ConnectionFactory
    {

        private static SQLiteConnection conn;

        public static SQLiteConnection RequestConnection()
        {
            try
            {
                conn = new SQLiteConnection("Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPC Documents\\database\\cars_performance.sqlite;Version=3;");
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static void DisposeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
