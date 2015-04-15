using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Club
    {
        private Adresse _adresse;
        private List<Cabane> _cabanes = new List<Cabane>();
        private List<Inscription> _membres = new List<Inscription>();
        private List<Sortie> _sorties = new List<Sortie>();
        private string _nom;
        private Responsable _responsable;
    
        public Club(string nom, Adresse adresse, Responsable responsable)
        {
            Nom = nom;
            Adresse = adresse;
            Responsable = responsable;
        }
    
        public string Nom
        {
            get
            {
                return _nom;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Le nom n'est pas valide.");
                }

                _nom = value;
            }
        }

        public Adresse Adresse
        {
            get
            {
                return _adresse;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "L'adresse n'est pas valide.");
                }

                _adresse = value;
            }
        }

        public Responsable Responsable
        {
            get
            {
                return _responsable;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Le responsable n'est pas valide.");
                }

                _responsable = value;
            }
        }

        public void AjouterMembre(Inscription membre)
        {
            if(membre != null)
            {
                _membres.Add(membre);
            }
        }

        public void AjouterSortie(Sortie sortie)
        {
            if (sortie != null)
            {
                _sorties.Add(sortie);
            }
        }

        public void AjouterCabane(Cabane cabane)
        {
            if (cabane != null)
            {
                _cabanes.Add(cabane);
            }
        }

        public List<Cabane> RechercherCabanes()
        {
            List<Cabane> cabanes = new List<Cabane>();

            foreach (Cabane cab in _cabanes)
            {
                cabanes.Add(cab);
            }

            return cabanes;
        }

        public List<Sortie> RechercherSorties()
        {
            List<Sortie> sorties = new List<Sortie>();

            foreach (Sortie sortie in _sorties)
            {
                sorties.Add(sortie);
            }

            return sorties;
        }

        public List<Inscription> RechercherInscriptions()
        {
            List<Inscription> inscriptions = new List<Inscription>();

            foreach (Inscription inscr in _membres)
            {
                inscriptions.Add(inscr);
            }

            return inscriptions;
        }
    }
}
