﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ticket_system
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con_comp"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    LoadTickets();
                }
                catch(Exception ex) 
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
        }

        protected void Reaguj_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            string idZgloszenia = button.CommandArgument;
            Response.Redirect($"Formularz_zgloszenia_admin.aspx?id={idZgloszenia}");
        }
        protected void LoadTickets()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                if (Session["User"] != null)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Zgloszenia_User ORDER BY DataZgloszenia ASC;", con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        Zgloszenia.DataSource = reader;
                        Zgloszenia.DataBind();
                        reader.Close();
                    }
                }
            }
        }
    }
}