using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice_de_Revision_WCS_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("~/PageConnection.aspx");
                }
            }
        }

        protected void Affecter_Click(object sender, EventArgs e)
        {
            Database.Execute(Connection =>
            {
                new SqlCommand("insert into Operation values(@compte,@date,@type,@motant)",Connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@compte",Comptes.SelectedValue.ToString()),
                        new SqlParameter("@date",DateTime.Now.Date.ToShortDateString()),
                        new SqlParameter("@type",Types.SelectedValue.ToString()),
                        new SqlParameter("@motant",Montant.Text),
                    }
                }.ExecuteNonQuery();
            }, () =>
            {
                Message.ForeColor = Color.Green;
                Message.Text = "L'operation a ete effectue";
            }, Error =>
            {
                Message.ForeColor = Color.Red;
                Message.Text = Error;
            });
        }
    }
}