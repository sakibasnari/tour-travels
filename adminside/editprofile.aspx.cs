using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace adminside
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
      

        protected void Page_Load(object sender, EventArgs e)
        {
            
                using (SqlCommand cmd = new SqlCommand("editprofile", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", Session["username"].ToString());
                    cmd.Parameters.AddWithValue("@pasword", Session["password"].ToString());

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                   
                        if (dr.Read())
                        {
                            textemail.Text = Session["username"].ToString();
                            fname.Text = dr["first_name"].ToString();
                            sname.Text = dr["second_name"].ToString();
                            TextBio.Text = dr["bio"].ToString();

                        }
                   
                }
                con.Close();
            }
            }



        protected void Button1_Click(object sender, EventArgs e)
        {
          
                using (SqlCommand cmd = new SqlCommand("UpdateUserDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@first_name", fname2.Text);
                    cmd.Parameters.AddWithValue("@second_name", sname2.Text);
                    cmd.Parameters.AddWithValue("@bio", TextBio2.Text);
                    cmd.Parameters.AddWithValue("@email", textemail.Text);

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    
                        Literal1.Text = "Changed successfully";
                        restore();
                    
                }
            }

        public void restore()
        {
             using (SqlCommand cmd = new SqlCommand("restoree", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", textemail.Text);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                       
                            textemail.Text = Session["username"].ToString();
                            fname.Text = dr["first_name"].ToString();
                            sname.Text = dr["second_name"].ToString();
                            TextBio.Text = dr["bio"].ToString();
                        }
                    }
                con.Close();
            }
            }
        

    }
}