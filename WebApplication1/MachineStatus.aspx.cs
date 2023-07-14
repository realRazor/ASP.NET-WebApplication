using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebApplication1.Classes;

namespace WebApplication1
{
    public partial class MachineStatus : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            string select = "SELECT MACHINE_NAME,STATUS FROM TBL_MACHINE";
            SqlCommand command = new SqlCommand(select, SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();
            
            SqlDataReader dr = command.ExecuteReader();

            GridView2.DataSource = dr;
            GridView2.DataBind();
            SqlConnectionClass.connection.Close();

        }
        protected void Row_Color(object sender, GridViewRowEventArgs e)

        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int status = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "STATUS"));

                e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center; // MACHINE_NAME hücresi için ortala
  
                if (status == 0)
                {
                    e.Row.BackColor = Color.Red;
                    e.Row.ForeColor = Color.White;

                }
                else 
                {
                    e.Row.BackColor = Color.Green;
                    e.Row.ForeColor = Color.Yellow;

                }
            }



        }



    }
}   