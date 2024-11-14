using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsClient
    {
        private string nas;
        private string nom;
        private string adresse;
        private clsListMaison maisons;
        private string email;
        private string tel;
        private string typeClient;

        public clsClient()
        {
            nas = nom = adresse = email = tel = typeClient = "Non definie";
            maisons = new clsListMaison();
        }

        public clsClient(string nas, string nom, string adresse,  string email, string tel, string typeClient)
        {
            this.nas = nas;
            this.nom = nom;
            this.adresse = adresse;
            maisons = new clsListMaison();
            this.email = email;
            this.tel = tel;
            this.typeClient = typeClient;
        }

        public string Nas
        {
            get => nas;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public clsListMaison Maisons
        {
            get => maisons;
            set => maisons = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Tel
        {
            get => tel;
            set => tel = value;
        }

        public string TypeClient
        {
            get => typeClient;
            set => typeClient = value;
        }

        public void Inscrire(string nas, string nom, string adresse, string email, string tel, string typeClient)
        {
            this.nas = nas;
            this.nom = nom;
            this.adresse = adresse;
            this.email = email;
            this.tel = tel;
            this.typeClient = typeClient;
            maisons = new clsListMaison();
        }

        
        public string Afficher()
        {
            string info = "NAS: " + nas + "<br />Nom: " + nom + "<br />Adresse: " + adresse +
                          "<br />Email: " + email + "<br />Tel: " + tel + "<br />Type de Client: " + typeClient +
                          "<br /> " + maisons.Afficher();

            

            return info;
        }
    }
}