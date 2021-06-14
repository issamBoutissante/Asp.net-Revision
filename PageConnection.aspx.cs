using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice_de_Revision_WCS_1
{
    public partial class PageConnection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ConnectionBtn_Click(object sender, EventArgs e)
        {
            Database.Execute(Connection =>
            {
                SqlDataReader reader = new SqlCommand($"select * from [Login] where Nom=@nom and MotPass=@motPass;", Connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@nom",Nom.Text),
                        new SqlParameter("@motPass",MotPass.Text)
                    }
                }.ExecuteReader();
                Login newLogin = null;
                while (reader.Read())
                {
                    newLogin = new Login()
                    {
                        Nom = reader["Nom"].ToString(),
                        MotPass = reader["MotPass"].ToString()
                    };
                }
                reader.Close();
                if (newLogin == null)
                {
                    ErrorMessage.Text = "Le Nom Ou Mot Pass Est Incorrect";
                    return;
                }
                Session["Login"] = newLogin;
                Response.Redirect("~/GestionClient.aspx");
            }, null,
            Error =>
            {
                ErrorMessage.Text = Error;
            });
        }
    }
}