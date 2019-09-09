using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace DocApi.DataLayer
{
    internal static class MySqlDbConnection
    {
        static string connectionString = @"Server=213.175.201.201; Database=docrepo; Uid=usr; Pwd=zUrf37^7";
        //static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\POC\MedEasy\App_Data\MedEasyServer.mdf;Integrated Security=True";

        public static DbCommand Command(DbConnection connection, string cmdText)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)connection);
        }

        public static DbConnection NewConnection
        {
            get
            {
                DbConnection connection = null;
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw;
                }

                return connection;
            }
        }
    }
}