using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsCompagnie
    {
        private string nom;
        private string adresse;
        private clsListAgent agents;
        private string email;
        private string telephone;
        private clsListClient clients;   
        private clsListMaison maisons;   

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public clsListAgent Agents { get => agents; set => agents = value; }
        public string Email { get => email; set => email = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public clsListClient Clients { get => clients; set => clients = value; }  
        public clsListMaison Maisons { get => maisons; set => maisons = value; }  

        public clsCompagnie()
        {
            this.Nom = "Non defini";
            this.Adresse = "Non defini";
            this.Agents = new clsListAgent();
            this.Email = "Non defini";
            this.Telephone = "Non defini";
            this.Clients = new clsListClient();   
            this.Maisons = new clsListMaison();   
        }

        public clsCompagnie(string nom, string adresse, string email, string telephone)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.agents = new clsListAgent();
            this.email = email;
            this.telephone = telephone;
            this.clients = new clsListClient();   
            this.maisons = new clsListMaison();   
        }

        public string afficher()
        {
            return "<br />Compagnie: " + nom +
                   "<br />Adresse: " + adresse +
                   "<br />Courriel: " + email +
                   "<br />Telephone: " + telephone;
        }

        public string AfficherToutesLesMaisons()
        {
            string toutesLesMaisons = "<br />Liste de toutes les maisons:<br />";

            foreach (clsMaison maison in maisons.Elements)  
            {
                toutesLesMaisons += "<br />Maison: " + maison.Afficher() + "<br />";
            }

            return toutesLesMaisons;
        }

        public string AfficherTousLesClients()
        {
            string tousLesClients = "<br />Liste de tous les clients:<br />";

            foreach (clsClient client in clients.Elements)  
            {
                tousLesClients += client.Afficher() + "<br />";


            }

            return tousLesClients;
        }


    }
}