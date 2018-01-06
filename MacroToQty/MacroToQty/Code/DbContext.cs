using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MacroToQty.Code
{
    public class DbContext : IDisposable
    {
        const string CONNECTION_STRING = "Server=(localdb)\\LocalBoii;Database=MacroToQty;Trusted_Connection=True;MultipleActiveResultSets=true;";
        SqlConnection connection = null;

        public DbContext()
        {
            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
        }

        public SqlConnection Connection 
        {
            get
            {
                return connection;
            }
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
