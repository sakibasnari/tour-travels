using System;
using System.Data.SqlClient;

namespace adminside
{
    public partial class editproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                if (!string.IsNullOrEmpty(Request.QueryString["code"]))
                {
                 
                    int code = Convert.ToInt32(Request.QueryString["code"]);
               
                    PopulateProductDetails(code);
                }
                else
                {
                 
                    pnlProductDetails.Visible = false;
                    pnlNoProduct.Visible = true;
                }
            }
        }

        

        protected void PopulateProductDetails(int code)
        {
           
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True"))
            {
            
                string query = "SELECT * FROM tour2 WHERE code = @code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@code", code);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    lblCode.Text = reader["code"].ToString();
                    txtName.Text = reader["nam"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                    txtDescription.Text = reader["dis"].ToString();
                }
                else
                {
                   
                    pnlProductDetails.Visible = false;
                    pnlNoProduct.Visible = true;
                }
                reader.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           
            int code = Convert.ToInt32(Request.QueryString["code"]);

           
            string nam = txtName.Text;
            string price = txtPrice.Text;
            string dis = txtDescription.Text;

         
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True"))
            {
            
                string query = "UPDATE tour2 SET nam = @nam, price = @price, dis = @dis WHERE code = @code";

       
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@dis", dis);

                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

           
            Response.Redirect("admindashbord.aspx");
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("admindashbord.aspx");
        }
    }
}
