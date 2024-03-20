using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace adminside
{
    public partial class forgetpasword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        DataTable tbl = new DataTable();
        //SqlCommandBuilder bld;
        Class1 obj = new Class1();
        //SqlDataAdapter adp;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("GetUserPasswordByEmail", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", TextBox1.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Literal1.Text = "Your password is: " + dr["pasword"].ToString();
                }
                else
                {
                    Literal1.Text = "No record found";
                }

                dr.Close();
                con.Close();
            }
        }


        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    //string change_pasword= "http://localhost:61827/change_pasword.aspx";   FOR CHANGE PASWORD LINK
        //    string to = "salishansari09@gmail.com"; //To address   kisko bhejna ha   
        //    string from = TextBox3.Text; //From address   kisse bhejna ha  
        //    MailMessage message = new MailMessage(from, to);

        //    string mailbody = "your pasword is :" + Literal1.Text;       /// +/* change_pasword*/ 
        //    message.Subject = "for pasword recovery";
        //    message.Body = mailbody;
        //    message.BodyEncoding = System.Text.Encoding.UTF8;    
        //    message.IsBodyHtml = true; // use for allow to html tag
        //    SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    // 587 is port no of gmail 
        //    System.Net.NetworkCredential basicCredential1 = new
        //    System.Net.NetworkCredential("salishansari09@gmail.com" , "dsngnukuszuhwhyg"); //yha gmailnam and pasword not rea pas of gmail ,this is 
        //    //                   secret key which shoot the smtp  and ye secret key we can create in my email acount
        //    client.EnableSsl = true;   //ssl allow
        //    client.UseDefaultCredentials = false;  // credetianals problem
        //    client.Credentials = basicCredential1;
        //    try
        //    {
        //        client.Send(message);
        //    }

        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //}
    }
}