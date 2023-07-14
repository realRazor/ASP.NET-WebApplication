using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Classes;

namespace WebApplication1
{
    public partial class MachineStatusChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Calistir(object sender, EventArgs e)
        {
            string mac_name = macname.Text;
            int sayi = 1;
            string update = "UPDATE TBL_MACHINE SET STATUS = '"+sayi+"' WHERE MACHINE_NAME='"+mac_name+"'";
            SqlConnectionClass.connection.Open();

            SqlCommand cmd = new SqlCommand(update, SqlConnectionClass.connection);
            
            cmd.ExecuteNonQuery();
            SqlConnectionClass.connection.Close();
            
        }
        protected void Button_Durdur(object sender, EventArgs e)
        {
            string mac_name = macname.Text;
            int sayi = 0;
            string update = "UPDATE TBL_MACHINE SET STATUS = '" + sayi + "'  WHERE MACHINE_NAME='" + mac_name + "'";
            SqlConnectionClass.CheckConnection();

            SqlCommand cmd = new SqlCommand(update, SqlConnectionClass.connection);

            cmd.ExecuteNonQuery();
            SqlConnectionClass.connection.Close();
        }

    }
}