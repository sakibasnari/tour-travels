﻿using System;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
     
      
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Textemail.Text= Session["username"].ToString();

        }

        protected void ok_Click(object sender, EventArgs e)
        {
            
                using (SqlCommand cmd = new SqlCommand("UpdateUserPassword", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", Textemail.Text);
                    cmd.Parameters.AddWithValue("@pasword", Textpasword.Text);

                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        Literal1.Text = "Password changed successfully!";
                    }
                    else
                    {
                        Response.Write("Please enter correct information.");
                    }
                }
            }
      

    }
}