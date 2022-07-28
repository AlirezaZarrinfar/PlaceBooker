using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Persistance.Connection
{
    public class Connection
    {
        static string conString = "Data Source=.;Initial Catalog=PlaceBooker_DB;Integrated Security=True";
        private static SqlConnection connection;
        public static SqlConnection sqlConnection
        {
            get
            {
                if (connection == null)
                {             
                    connection = new SqlConnection(conString);
                    connection.Open();
                }
                return connection;
            }
        }
    }
}
