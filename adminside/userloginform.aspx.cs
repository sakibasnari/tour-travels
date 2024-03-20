using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient ;
using System.Web.Configuration;



namespace adminside
{
    public partial class adminlogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        DataTable tbl=new DataTable();
        //SqlCommandBuilder bld;
       Class1 obj = new Class1();
        //SqlDataAdapter adp;

        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check if the email is admin
            if (Text__email.Text == "admin@.com")
            {
                // Assuming "con" is already defined as your SqlConnection
                using (SqlCommand cmd = new SqlCommand("GetUserByEmailAndPassword", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", Text__email.Text);
                    cmd.Parameters.AddWithValue("@pasword", Text__pasword.Text);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();

                    if (result != null)
                    {
                        Session["username"] = Text__email.Text;
                        Session["password"] = Text__pasword.Text;
                        Response.Redirect("admindashbord.aspx");
                    }
                    else
                    {
                        Literal1.Text = "Enter the correct information";
                    }
                }
            }
            else
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserByEmailAndPassword", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@email", Text__email.Text);
                        cmd.Parameters.AddWithValue("@pasword", Text__pasword.Text);

                        con.Open();
                        object result = cmd.ExecuteScalar();
                        con.Close();

                        if (result != null)
                        {
                            Session["username"] = Text__email.Text;
                            Session["password"] = Text__pasword.Text;

                          
                            Response.Redirect("dhbord2.aspx");
                        }
                        else
                        {
                            Literal1.Text = "Enter the correct information";
                        }
                    }
                }
                catch
                {
                    Literal1.Text = "Enter the correct information";
                }
            }
        






        //stack management -- two side server and client side
        //
        //---    server-- Session ,
        //     client---coccki, hidden field(foor temparry)
        /// cokie-- 2 -- parmanent and parsestent
        //      
        //seesion - jha se start hua vhi ana information mange krna 
        //        information paass one page to another without url



    }

    //protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    //{
    //    if (Request.Cookies["cok"] != null)
    //    {
    //        if (CheckBox1.Checked == true)
    //        {
    //            Text__pasword.Text = Request.Cookies["cok"].Value;
    //        }

    //    }
    //}
}
}