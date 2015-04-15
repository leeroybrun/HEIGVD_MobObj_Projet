using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Adresse
    {
        private string _rue;
        private int _noRue;
        private int _npa;
        private string _ville;
    
        public Adresse(string rue, int noRue, int npa, string ville)
        {
            Rue = rue;
            NoRue = noRue;
            NPA = npa;
            Ville = ville;
        }
    
        public string Rue
        {
            get
            {
                return _rue;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "La rue d'une adresse doit être spécifié.");
                }

                _rue = value;
            }
        }

        public int NoRue
        {
            get
            {
                return _noRue;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentNullException("value", "Le no de rue n'est pas valide.");
                }

                _noRue = value;
            }
        }

        public int NPA
        {
            get
            {
                return _npa;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("value", "Le NPA n'est pas valide.");
                }

                _npa = value;
            }
        }

        public string Ville
        {
            get
            {
                return _ville;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "La ville d'une adresse doit être spécifiée.");
                }

                _ville = value;
            }
        }
    }
}
