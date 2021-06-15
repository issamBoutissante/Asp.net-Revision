using System;

namespace Exercice_de_Revision_WCS_1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Afficher_Click(object sender, EventArgs e)
        {
            WebServiceClient ws = new WebServiceClient();
            ClientGridView.DataSource= ws.GetClient(Mois.Text);
            ClientGridView.DataBind();
        }
    }
}