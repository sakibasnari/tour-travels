using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace adminside
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True");
        SqlCommand cmd;

        SqlDataAdapter adp;
        DataTable tbl = new DataTable();
        SqlCommandBuilder bld;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
                FileUpload1.SaveAs(Request.PhysicalApplicationPath + "//upload//" + FileUpload1.FileName);


                using (SqlCommand cmd = new SqlCommand("InsertTour", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@code", Textcode.Text);
                    cmd.Parameters.AddWithValue("@nam", Textname.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(Textprice.Text));
                    cmd.Parameters.AddWithValue("@dis", Textdisc.Text);
                    cmd.Parameters.AddWithValue("@img", FileUpload1.FileName);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            

            Response.Redirect("admindashbord.aspx");
        


    }
        }
    
    }