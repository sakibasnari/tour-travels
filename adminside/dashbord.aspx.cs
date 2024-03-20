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
            string querry1 = "select * from tour2";
            adp = new SqlDataAdapter(querry1, con);
            adp.Fill(tbl);
            DataList1.DataSource = tbl;
            DataList1.DataBind();
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("userloginform.aspx");
        }
    }
}
