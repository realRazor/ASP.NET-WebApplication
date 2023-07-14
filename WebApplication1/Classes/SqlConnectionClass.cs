using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=RAZOR\\SQLEXPRESS;Initial Catalog=DB_MES;Integrated Security=True");
        
        public static void CheckConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
            else
            {

            }
            
        }
    }

}