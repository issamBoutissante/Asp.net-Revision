using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Exercice_de_Revision_WCS_1
{
    /// <summary>
    /// Summary description for WebServiceClient
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceClient : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetClient(string mois)
        {
            DataTable clients = new DataTable();
            Database.Execute(Connection =>
            {
                new SqlDataAdapter()
                {
                    SelectCommand = new SqlCommand("select * from Client C join Operation O on C.Compte = O.Compte where Month([Date]) = @month", Connection)
                    {
                        Parameters =
                        {
                            new SqlParameter("@month",mois)
                        }
                    }
                }.Fill(clients);
            });
            return clients;
        }
    }
}
