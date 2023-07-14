using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using WebApplication1.Classes;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
            
        {
            if(!IsPostBack)
            {
                SqlCommand commandlist = new SqlCommand("Select * from TBL_MACHINE", SqlConnectionClass.connection);

                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = commandlist.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                SqlConnectionClass.connection.Close();
            }
        }
        

        protected void Yeni_Ekle_Click(object sender, EventArgs e)
        {
            string machineName = mac_name.Text;
            string recordingDate = rec_date.Text;
            string status = mac_status.Text;

            string insert = "INSERT INTO TBL_MACHINE VALUES (@name,@date,@s)";
            SqlCommand command = new SqlCommand(insert, SqlConnectionClass.connection);

            
            command.Parameters.AddWithValue("@name", machineName);
            command.Parameters.AddWithValue("@date", recordingDate);
            command.Parameters.AddWithValue("@s", status);
            SqlConnectionClass.CheckConnection();
            command.ExecuteNonQuery();

            LoadTable();
            SqlConnectionClass.connection.Close();
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            int mac_id;
            for(int i=0;i<GridView1.Rows.Count;i++)
            {
                CheckBox checkSelect = (CheckBox)GridView1.Rows[i].FindControl("CheckSelect");
                if (checkSelect.Checked)

                {
                    SqlConnectionClass.CheckConnection();
                    mac_id = Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    SqlCommand cmd = new SqlCommand("DELETE TBL_MACHINE WHERE ID='"+mac_id+"'", SqlConnectionClass.connection);
                    cmd.ExecuteNonQuery();
                    SqlConnectionClass.connection.Close();
                }
            }
            LoadTable();
        }
        void LoadTable()
        {

            SqlCommand commandlist = new SqlCommand("Select * from TBL_MACHINE", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            SqlDataReader dr = commandlist.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            SqlConnectionClass.connection.Close();
        }
        
    }



}
