using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminside
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True");
        SqlDataAdapter adp;
        DataTable tbl = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        protected void Bind()
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

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("userloginform.aspx");
        }
    }
}
