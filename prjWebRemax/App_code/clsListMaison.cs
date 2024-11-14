using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsListMaison
    {
        // cacher ou encapsuler une collection dictionnary 
        // et utiliser ses methodes necessaires
        private Dictionary<string, clsMaison> ListeCachee;

        public clsListMaison()
        {
            ListeCachee = new Dictionary<string, clsMaison>();

        }

        public int Nombre
        {
            get { return ListeCachee.Count; }
        }

        public Dictionary<string, clsMaison>.ValueCollection Elements
        {
            get => ListeCachee.Values;
        }

        public bool Ajouter(clsMaison uneMaison)
        {
            if (ListeCachee.ContainsKey(uneMaison.Numero) == false)
            {
                ListeCachee.Add(uneMaison.Numero, uneMaison);
                return true;
            }
            else { return false; }
        }

        public bool Supprimer(string numero)
        {
            return ListeCachee.Remove(numero);
        }

        public clsMaison Trouver(string numero)
        {
            if (ListeCachee.ContainsKey(numero) == true)
            {
                return ListeCachee[numero];
            }
            else { return null; }
        }

        public bool Existe(string numero)
        {
            return ListeCachee.ContainsKey(numero);
        }

        public string Afficher()
        {
            string info = "<br />Liste de maisons <br /> ";
            foreach (clsMaison uneMaison in ListeCachee.Values)
            {
                info += uneMaison.Afficher() + "<br />-----------<br />";
            }
            return info;
        }
    }
}