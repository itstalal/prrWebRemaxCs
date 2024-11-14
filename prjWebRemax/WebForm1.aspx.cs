using prjWebRemax.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebRemax
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           clsCompagnie Remax = new clsCompagnie("Remax","hochelaga","talal@gmail.com","0605040505");     
           clsAgent agent = new clsAgent("120", "talal", "talal@gmail.com", "1250", "actif", 15000);
           clsClient client = new clsClient("150","talal","inconnue","talal@gmail.dev","514895687","acheteur");
           clsMaison maison = new clsMaison("120", "appartement", "quelque part", 1500, 5, "luxe");
          
            client.Maisons.Ajouter(maison);
            agent.Clients.Ajouter(client);
            
            Remax.Agents.Ajouter(agent);
            Remax.Clients.Ajouter(client);
            Remax.Maisons.Ajouter(maison);
            Label1.Text = Remax.AfficherTousLesClients();

        }
    }
}