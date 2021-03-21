using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace SAST.WebApp.Infrastructure
{
    public class Repository
    {
        public object UnsafeQuery(
            string connection, string name, string password)
        {
            
            SqlConnection someConnection = new SqlConnection(connection);
            SqlCommand someCommand = new SqlCommand();
            someCommand.Connection = someConnection;

            someCommand.CommandText = "SELECT AccountNumber FROM Users " +
                                      "WHERE Username='" + name +
                                      "' AND Password='" + password + "'";

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            someConnection.Close();
            return accountNumber;
        }
    }
}
