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
    public partial class WebForm3 : System.Web.UI.Page
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

        protected void Afficher_Click(object sender, EventArgs e)
        {
            Database.Execute(Connection =>
            {
                DataTable historiqueTable = new DataTable();
                new SqlDataAdapter()
                {
                    SelectCommand = new SqlCommand("select Date as 'Date Operation',Type,Montant from Operation " +
                    "where Compte=@compte and Date between @d1 and @d2",Connection)
                    {
                        Parameters =
                        {
                            new SqlParameter("@compte",Comptes.SelectedValue.ToString()),
                            new SqlParameter("@d1",Date1.Text),
                            new SqlParameter("@d2",Date2.Text),
                        }
                    }
                }.Fill(historiqueTable);
                historiqueGridView.DataSource = historiqueTable;
                historiqueGridView.DataBind();
                Message.Text = historiqueTable.Rows.Count.ToString();
                decimal solde = (decimal)new SqlCommand("select SUM(Montant) from Operation where Compte=@compte",Connection)
                {
                    Parameters =
                    {
                        new SqlParameter("@compte",Comptes.SelectedValue.ToString())
                    }
                }.ExecuteScalar();
                Solde.Text = solde.ToString();
            }, null,
           Error =>
           {
               Message.ForeColor = Color.Red;
               Message.Text = Error;
           });
        }
    }
}