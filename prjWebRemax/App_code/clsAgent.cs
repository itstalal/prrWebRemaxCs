using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsAgent
    {
        private string nas;
        private string nom;
        private clsListClient clients;
        private string email;
        private string telephone;
        private string statut;
        private decimal salaire;

        public clsAgent()
        {
            nas = nom = email = telephone = statut = "Non definie";
            salaire = 0;
            clients = new clsListClient();
        }

        public clsAgent(string nas, string nom,  string email, string telephone, string statut, decimal salaire)
        {
            this.nas = nas;
            this.nom = nom;
            this.clients = new clsListClient() ;
            this.email = email;
            this.telephone = telephone;
            this.statut = statut;
            this.salaire = salaire;
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

        public clsListClient Clients
        {
            get => clients;
            set => clients = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Telephone
        {
            get => telephone;
            set => telephone = value;
        }

        public string Statut
        {
            get => statut;
            set => statut = value;
        }

        public decimal Salaire
        {
            get => salaire;
            set => salaire = value;
        }

        public void Engager(string nas, string nom, string email, string telephone, decimal salaire)
        {
            this.nas = nas;
            this.nom = nom;
            this.email = email;
            this.telephone = telephone;
            this.salaire = salaire;
            this.statut = "actif";
        }

        public string Afficher()
        {
            string info = "NAS: " + nas + "<br />Nom: " + nom + "<br />Email: " + email +
                          "<br />Telephone: " + telephone + "<br />Statut: " + statut +
                          "<br />Salaire: " + salaire.ToString() + "<br />Clients: " + clients.Afficher();

            return info;
        }

        public string ToutesLesMaisons()
        {
            string toutesLesMaisons = " <br />Liste de toutes les maisons: <br /> ";

            foreach (clsClient client in clients.Elements)
            {
                toutesLesMaisons += client.Afficher();
            }

            return toutesLesMaisons;
        }

    }
}