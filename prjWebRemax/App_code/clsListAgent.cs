using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebRemax.App_code
{
    public class clsListAgent
    {
        // cacher ou encapsuler une collection dictionnary 
        // et utiliser ses methodes necessaires
        private Dictionary<string, clsAgent> ListeCachee;

        public clsListAgent()
        {
            ListeCachee = new Dictionary<string, clsAgent>();

        }

        public int Nombre
        {
            get { return ListeCachee.Count; }
        }

        public Dictionary<string, clsAgent>.ValueCollection Elements
        {
            get => ListeCachee.Values;
        }

        public bool Ajouter(clsAgent unAgent)
        {
            if (ListeCachee.ContainsKey(unAgent.Nas) == false)
            {
                ListeCachee.Add(unAgent.Nas, unAgent);
                return true;
            }
            else { return false; }
        }

        public bool Supprimer(string nas)
        {
            return ListeCachee.Remove(nas);
        }

        public clsAgent Trouver(string nas)
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
            string info = "<br />Liste d'agents <br /> ";
            foreach (clsAgent unAgent in ListeCachee.Values)
            {
                info += unAgent.Afficher() + "<br />-----------<br />";
            }
            return info;
        }
    }
}