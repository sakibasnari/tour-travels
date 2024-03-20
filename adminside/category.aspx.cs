using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace adminside
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        protected void Page_Load(object sender, EventArgs e)
        {
            string querry = "select cat_name from category10";
            adp = new SqlDataAdapter(querry, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
             DropDownList1.DataSource= tbl;
            DropDownList1.DataTextField = "cat_name";
         //   DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("--select--","0"));






        }

        protected void add_cat_Click(object sender, EventArgs e)
        {
          try
          { 
          string querry = "select * from category10  where cat_name='" + category.Text + "'";
            adp = new SqlDataAdapter(querry,con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);     
              if(tbl.Rows.Count > 0)
                {   
                    Literal1.Text = "already inserted";
                    category.Text = "";

                }

                else
                {
                    string querry1 = "_category10";
                    cmd = new SqlCommand(querry1, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cat_name", category.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                   
                    Literal1.Text = "insert succefully";
                    category.Text = "";
                }

            }

            finally
            {
                con.Close();
            }


        }

        protected void sub_category_Click(object sender, EventArgs e)
        {
            try {
                string querry = "select * from sub_category  where sub_cat_name='" + subcategory.Text + "'";
                adp = new SqlDataAdapter(querry, con);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                if (tbl.Rows.Count > 0)
                {
                    Literal2.Text = "already inserted";
                    subcategory.Text = "";

                }

                else
                {
                    string querry1 = " _sub_category";
                    cmd = new SqlCommand(querry1, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cat_name", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@sub_cat_name", subcategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    Literal2.Text = "insert succefully";
                    subcategory.Text = "";
                }
            }
            finally
            {
                con.Close();
            }
            }
        




    
    }
}