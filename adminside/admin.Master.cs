﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adminside
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {

                Literal1.Text = Session["username"].ToString();


            }
            else
            {
                Response.Redirect("userloginform.aspx");
            }

        }

            protected void LinkButton1_Click(object sender, EventArgs e)
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("userloginform.aspx");

            }

            protected void LinkButton2_Click(object sender, EventArgs e)
            {
                Response.Redirect("change_pasword_admin.aspx");
            }

            protected void LinkButton_editpf_Click(object sender, EventArgs e)
            {
                Response.Redirect("editprofile.aspx");
            }

            protected void add_item_Click(object sender, EventArgs e)
            {

                Response.Redirect("category.aspx");
            }

        protected void add_product_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_product.aspx");
        }
    }
    }

