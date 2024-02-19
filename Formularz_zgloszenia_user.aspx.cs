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
    public partial class WebForm5 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con_comp"].ConnectionString;
        protected void Guzik_Zglos_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null) {

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string tytul = Tytul_zgloszenia.Text;
                    string priorytet = Priorytet_zgloszenia.Text;
                    string user = Session["User"].ToString();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Zgloszenia_User (Tytul, Priorytet, KtoZglosil) " +
                        "VALUES (@Tytul, @Priorytet, @KtoZglosil);", con))
                    {
                        cmd.Parameters.AddWithValue("@Tytul", tytul);
                        cmd.Parameters.AddWithValue("@Priorytet", priorytet);
                        cmd.Parameters.AddWithValue("@KtoZglosil", user);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Response.Redirect("panel_user.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert(Nie udało się!);</alert>");
                        }
                    }
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Zgloszenia_User WHERE ID = (SELECT MAX(ID) FROM Zgloszenia_User)", con)) { 
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                        while (reader.Read())
                        {
                            int id_zgloszenia = reader.GetInt32(reader.GetOrdinal("ID"));
                            id_zgloszenia++;
                            ID_zgloszenia.Text = id_zgloszenia.ToString();

                        }
                    }
                }
            }
        }
    }
}