using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
            try
            {
                string login = user_login.Text;
                string password = user_password.Text;

                //connect with Database SMSS
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    
                    //Get everyone User from Table Users
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Login = @Login AND Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    
                    

                    //Find out if user is in database, and check if User has Admin privelanges
                    if (reader.HasRows)
                    {
                        /*
                        string script = $"alert({reader[2]});";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", script, true);
                        */
                        while (reader.Read())
                        {
                            Session["User"] = reader.GetString(reader.GetOrdinal("Login"));
                            

                            bool isADM = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
                            if (!isADM)
                            {
                                Response.Redirect("panel_user.aspx");
                            }
                            else
                            {
                                Response.Redirect("panel_admin.aspx");
                            }
                        }
                        reader.Close();
                    }
                    else
                    {
                        Response.Write("<script>alert('Nie ma takiego usera');</script>");
                    }

                }
            }

            catch (Exception ex) 
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    } 
}