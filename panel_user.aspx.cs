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

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Zgloszenia_User", con))
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