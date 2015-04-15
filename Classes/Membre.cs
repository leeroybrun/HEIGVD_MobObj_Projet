using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Membre
    {
        private Adresse _adresse;
        private string _nom;
        private string _prenom;
        private List<Sortie> _sorties = new List<Sortie>();
        private List<Inscription> _inscriptions = new List<Inscription>();
    
        public Membre(string nom, string prenom, Adresse adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
        }
    
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Le nom n'est pas valide.");
                }

                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Le prénom n'est pas valide.");
                }

                _prenom = value;
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
                if(value == null)
                {
                    throw new ArgumentNullException("value", "L'adresse n'est pas valide.");
                }

                _adresse = value;
            }
        }

        public Inscription InscriptionClub(Club club)
        {
            Inscription inscr = null;

            if (club != null)
            {
                inscr = new Inscription(this, club, EtatInscription.AttenteValidation);

                _inscriptions.Add(inscr);
                club.AjouterMembre(inscr);
            }

            return inscr;
        }

        public bool EstInscritClub(Club club)
        {
            bool inscrit = false;

            for (int i = 0; i < _inscriptions.Count && inscrit == false; i++)
            {
                inscrit = _inscriptions[i].Club == club;
            }

            return inscrit;
        }

        public Inscription RechercheInscriptionClub(Club club)
        {
            Inscription inscr = null;

            for (int i = 0; i < _inscriptions.Count && inscr == null; i++)
            {
                if(_inscriptions[i].Club == club)
                {
                    inscr = _inscriptions[i];
                }
            }

            return inscr;
        }

        public void InscriptionSortie(Sortie sortie)
        {
            if (sortie != null)
            {
                Inscription inscrClub = RechercheInscriptionClub(sortie.Club);

                if (inscrClub != null && inscrClub.Etat == EtatInscription.Validee)
                {
                    if(!sortie.EstComplet())
                    {
                        _sorties.Add(sortie);
                        sortie.AjouterInscrit(this);
                    }
                    else
                    {
                        throw new Exception("La sortie est déjà compète !");
                    }
                }
            }
        }

        public List<Inscription> RechercherInscriptions()
        {
            List<Inscription> inscriptions = new List<Inscription>();

            foreach (Inscription inscr in _inscriptions)
            {
                inscriptions.Add(inscr);
            }

            return inscriptions;
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

        public List<Sortie> RechercherSortiesClubs()
        {
            List<Sortie> sorties = new List<Sortie>();

            foreach (Inscription inscr in _inscriptions)
            {
                if(inscr.Etat == EtatInscription.Validee)
                {
                    foreach (Sortie sortie in inscr.Club.RechercherSorties())
                    {
                        sorties.Add(sortie);
                    }
                }
            }

            return sorties;
        }

        public override string ToString()
        {
            return Prenom +" "+ Nom;
        }
    }
}
