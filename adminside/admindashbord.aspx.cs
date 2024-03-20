using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace adminside
{
    public partial class admindashbord : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True");
        SqlDataAdapter adp;
        DataTable tbl = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
        {
            string query = "SELECT * FROM tour2";
            adp = new SqlDataAdapter(query, con);
            adp.Fill(tbl);
            DataList1.DataSource = tbl;
            DataList1.DataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            string code = btnEdit.CommandArgument; 

          
            Response.Redirect($"EditProduct.aspx?code={code}");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            string productId = btnDelete.CommandArgument; 

     
            DeleteProduct(productId);

   
            BindData();
        }

        protected void DeleteProduct(string productId)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM tour2 WHERE code = @productId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
         
            }
            finally
            {
                con.Close();
            }
        }
        protected void gotoalert(object sender, EventArgs e)
        {


            
            string script = "alert(' your ticket  confermed . thnak you ');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }

    }
}
