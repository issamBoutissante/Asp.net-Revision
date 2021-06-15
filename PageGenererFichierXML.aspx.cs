using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice_de_Revision_WCS_1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Login"] == null)
                {
                    Response.Redirect("~/PageConnection.aspx");
                }
            }
        }

        protected void GenereFichierXML_Click(object sender, EventArgs e)
        {
            Database.Execute(Connection =>
            {
                DataSet ds = new DataSet();
                new SqlDataAdapter()
                {
                    SelectCommand = new SqlCommand("select Nom,Prenom,[Date] as [Date Operation],[Type] as [Type Operation],Montant " +
                    "from Client as C join Operation as O on C.Compte=O.Compte where [Date] between @d1 and @d2", Connection)
                    {
                        Parameters =
                        {
                            new SqlParameter("@d1",Date1.Text),
                            new SqlParameter("@d2",Date2.Text)
                        }
                    }
                }.Fill(ds,"Operation");
                ds.Tables["Operation"].WriteXml(Server.MapPath("~") + "operations.xml");
            });
        }
    }
}