using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ticket_system
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con_comp"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idZgloszenia = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(idZgloszenia) )
                {
                    LoadData(idZgloszenia);
                }
            }
        }
        private void LoadData(string idZgloszenia)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                if (con.State == System.Data.ConnectionState.Closed) {
                    con.Open();
                }

                if (Session["User"] != null)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Zgloszenia_User WHERE ID = @ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", idZgloszenia);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            ID.Text = reader["ID"].ToString();
                            Tytul.Text = reader["Tytul"].ToString();
                            //Status.Text = reader["Status"].ToString();
                            Priorytet.Text = reader["Priorytet"].ToString();
                            DataZgloszenia.Text = reader["DataZgloszenia"].ToString();
                            KtoZglosil.Text = reader["KtoZglosil"].ToString();

                        }
                    }
                }
            }

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                if (Session["User"] != null)
                {
                    string idZgloszenia = Request.QueryString["id"];
                    int id = int.Parse(idZgloszenia);
                    string status = StatusBox.SelectedValue;
                   

                    using (SqlCommand cmd = new SqlCommand("UPDATE Zgloszenia_User SET Status = @Status WHERE ID = @idZgloszenia", con))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue ("@idZgloszenia", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Response.Redirect("panel_admin.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert(Nie udało się!);</script>");
                        }
                    }
                }
            }
        }
    }

}