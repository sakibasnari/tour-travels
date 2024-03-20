using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace adminside
{
    public partial class newaccount : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
       
        DataTable tbl = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlCommand cmd = new SqlCommand("InsertUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // Add parameters
                cmd.Parameters.AddWithValue("@email", Text__email.Text);
                cmd.Parameters.AddWithValue("@pasword", Text__pasword.Text);
                cmd.Parameters.AddWithValue("@first_name", Text_firstname.Text);
                cmd.Parameters.AddWithValue("@second_name", Text_secondname.Text);
                cmd.Parameters.AddWithValue("@bio", Text_bio.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

              
                    Response.Redirect("dhbord2.aspx");
              
            }

        }


    }
}