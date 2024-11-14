using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsListClient
    {
        // cacher ou encapsuler une collection dictionnary 
        // et utiliser ses methodes necessaires
        private Dictionary<string, clsClient> ListeCachee;

        public clsListClient()
        {
            ListeCachee = new Dictionary<string, clsClient>();

        }

        public int Nombre
        {
            get { return ListeCachee.Count; }
        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get => ListeCachee.Values;
        }

        public bool Ajouter(clsClient unClient)
        {
            if (ListeCachee.ContainsKey(unClient.Nas) == false)
            {
                ListeCachee.Add(unClient.Nas, unClient);
                return true;
            }
            else { return false; }
        }

        public bool Supprimer(string nas)
        {
            return ListeCachee.Remove(nas);
        }

        public clsClient Trouver(string nas)
        {
            if (ListeCachee.ContainsKey(nas) == true)
            {
                return ListeCachee[nas];
            }
            else { return null; }
        }

        public bool Existe(string nas)
        {
            return ListeCachee.ContainsKey(nas);
        }

        public string Afficher()
        {
            string info = "<br />Liste de comptes <br /> ";
            foreach (clsClient unClient in ListeCachee.Values)
            {
                info += unClient.Afficher() + "<br />-----------<br />";
            }
            return info;
        }
    }
}