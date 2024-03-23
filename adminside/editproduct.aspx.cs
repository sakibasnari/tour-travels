using System;
using System.Data;
using System.Data.SqlClient;

namespace adminside
{
    public partial class editproduct : System.Web.UI.Page
    {
        string connectionString = "Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True";

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
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SelectProductDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
            }
            catch (Exception ex)
            {
               
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(Request.QueryString["code"]);
                string nam = txtName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                string dis = txtDescription.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

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
            catch (Exception ex)
            {
               
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("admindashbord.aspx");
        }
    }
}
