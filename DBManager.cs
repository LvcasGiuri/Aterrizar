using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class DBManager
    {
        SqlConnection connection;
        SqlCommand command;

        public DBManager()
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Aterrizar"].ConnectionString);
        }

        public SqlConnection getConnection()
        {
            return this.connection;
        }

    }
}