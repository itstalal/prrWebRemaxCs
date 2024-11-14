using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsMaison
    {
        private string numero;
        private string type;
        private string adresse;
        private decimal prix;
        private int nombreChambre;
        private string courteDescription;

        public clsMaison()
        {
            numero = type = adresse = courteDescription = "Non definie";
            prix = 0;
            nombreChambre = 0;
        }

        public clsMaison(string numero, string type, string adresse, decimal prix, int nombreChambre, string courteDescription)
        {
            this.numero = numero;
            this.type = type;
            this.adresse = adresse;
            this.prix = prix;
            this.nombreChambre = nombreChambre;
            this.courteDescription = courteDescription;
        }

        public string Numero
        {
            get => numero;
            set
            {
                numero = value;
            }
        }

        public string Type
        {
            get => type;
            set
            {
                type = value;
            }
        }

        public string Adresse
        {
            get => adresse;
            set
            {
                adresse = value;
            }
        }

        public decimal Prix
        {
            get => prix;
            set
            {
                prix = value;
            }
        }

        public int NombreChambre
        {
            get => nombreChambre;
            set
            {
                nombreChambre = value;
            }
        }

        public string CourteDescription
        {
            get => courteDescription;
            set
            {
                courteDescription = value;
            }
        }

        public void Ajouter(string numero, string type, string adresse, decimal prix, int nombreChambre, string courteDescription)
        {
            this.numero = numero;
            this.type = type;
            this.adresse = adresse;
            this.prix = prix;
            this.nombreChambre = nombreChambre;
            this.courteDescription = courteDescription;
        }

        public string Afficher()
        {
            return "Numero: " + numero + "<br />Type: " + type + "<br />Adresse: " + adresse + "<br />Prix: " + prix.ToString("C") +
                   "<br />Nombre de Chambres: " + nombreChambre + "<br />Description: " + courteDescription;
        }

    }
}