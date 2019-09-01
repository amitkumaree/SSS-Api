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
        static string connectionString = @"Server=98.142.221.58; Database=world02_docrepo; Uid=world02_sss; Pwd=hmd^3kz#MRFE";
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