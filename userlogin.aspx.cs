﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ticket_system
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LogInCheck(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('BRIAR');</script>");

            try
            {
                /*SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("", con);
                */
                string login_value = user_login.Text;
                Response.Write("<script>alert(" + "HUJ" + ");</script>");

            }
            catch(Exception ex) { 
            
            }
        }
    }
}