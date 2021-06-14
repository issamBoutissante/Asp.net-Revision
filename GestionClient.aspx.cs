using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice_de_Revision_WCS_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Ajouter_Click(object sender, EventArgs e)
        {
            Database.Execute(Connection =>
            {
                new SqlCommand("insert into Client values(@compte,@nom,@prenom,@adresse,@email,@motPass)", Connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@compte",Compte.Text),
                        new SqlParameter("@nom",Nom.Text),
                        new SqlParameter("@prenom",Prenom.Text),
                        new SqlParameter("@adresse",Adresse.Text),
                        new SqlParameter("@email",Email.Text),
                        new SqlParameter("@motPass",MotPass.Text),
                    }
                }.ExecuteNonQuery();
            }, () =>
            {
                Message.ForeColor = Color.Green;
                Message.Text = "L'jout a ete effectue";
                GridView1.DataBind();
            }, Error =>
            {
                Message.ForeColor = Color.Red;
                Message.Text = Error;
            });
        }
    }
}