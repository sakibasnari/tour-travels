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
            using (SqlCommand cmd = new SqlCommand("SelectTourData", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();

                adp.Fill(tbl);

                DataList1.DataSource = tbl;
                DataList1.DataBind();
            }
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
             using (SqlCommand cmd = new SqlCommand("DeleteTour", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productId", productId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        protected void gotoalert(object sender, EventArgs e)
        {


            
            string script = "alert(' your ticket  confermed . thnak you ');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }

    }
}
