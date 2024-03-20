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
    public partial class dhbord2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3I7N9AP\\SQLEXPRESS;Initial Catalog=tech;Integrated Security=True");
        SqlDataAdapter adp;
        DataTable tbl = new DataTable();




        protected void Page_Load(object sender, EventArgs e)
        {
            string querry1 = "select * from tour2";
            adp = new SqlDataAdapter(querry1, con);
            adp.Fill(tbl);

            if (!IsPostBack)
            {
                Bind();

            }

        }
        protected void Bind()
        {
            DataList1.DataSource = tbl;
            DataList1.DataBind();
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            
            string script = "alert(' your ticket  confermed . thnak you ');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }
    }
}