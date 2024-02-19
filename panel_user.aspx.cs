using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ticket_system
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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
                    Response.Write("<scrip>alert('" + ex.Message + "');</script>");
                }
            }
        }

        private void LoadTickets()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                if (Session["User"] != null)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Zgloszenia_User WHERE KtoZglosil = @Login", con))
                    {

                        cmd.Parameters.AddWithValue("@Login", Session["User"].ToString());
                        SqlDataReader reader = cmd.ExecuteReader();

                        Zgloszenia.DataSource = reader;
                        Zgloszenia.DataBind();

                        reader.Close();
                    }
                }
            }
        }
        protected void Nowe_zgloszenie(object sender, EventArgs e)
        {
            Response.Redirect("Formularz_zgloszenia_user.aspx");
        }
    }
}