using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FacadePattern
{
    public class SQLFacade
    {
        public static bool ExecuteSQL(string sql)
        {
            SqlConnection connection = new SqlConnection("connection string");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            command.ExecuteNonQuery();

            return true;
        }
    }
}
