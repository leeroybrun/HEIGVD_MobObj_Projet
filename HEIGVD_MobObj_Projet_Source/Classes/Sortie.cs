using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Sortie
    {
        private string _nom;
        private Membre _organisateur;
        private Club _club;
        private DateTime _dateDepart;
        private List<Membre> _inscrits = new List<Membre>();
        private List<Escale> _escales = new List<Escale>();
        private Adresse _lieuDepart;
        private float _prixDeBase;
    
        public Sortie(string nom, Membre organisateur, Adresse lieuDepart, DateTime dateDepart, float prixDeBase, Club club)
        {
            Nom = nom;
            Organisateur = organisateur;
            LieuDepart = lieuDepart;
            DateDepart = dateDepart;
            PrixDeBase = prixDeBase;
            Club = club;
        }
    
        public DateTime DateDepart
        {
            get
            {
                return _dateDepart;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "La date de depart n'est pas valide.");
                }

                _dateDepart = value;
            }
        }

        public Adresse LieuDepart
        {
            get
            {
                return _lieuDepart;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Le lieux de départ n'est pas valide.");
                }

                _lieuDepart = value;
            }
        }

        public Club Club
        {
            get
            {
                return _club;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Le club n'est pas valide.");
                }

                _club = value;
            }
        }

        public Membre Organisateur
        {
            get
            {
                return _organisateur;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "L'organisateur n'est pas valide.");
                }

                _organisateur = value;
            }
        }

        public float PrixDeBase
        {
            get
            {
                return _prixDeBase;
            }
            set
            {
                // Prix pas plus bas que 0
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "Le prix de base n'est pas valide.");
                }

                _prixDeBase = value;
            }
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

        public void AjouterEscale(Escale escale)
        {
            if(escale != null)
            {
                _escales.Add(escale);
            }
        }

        public float CalculPrix()
        {
            float prix = 0;

            for(int i = 0; i < _escales.Count; i++)
            {
                prix += _escales[i].CalculPrix();
            }

            return prix;
        }

        public int NbMembresInscrits()
        {
            return _inscrits.Count;
        }

        public int MaxPlaces()
        {
            int places = 200000;

            for (int i = 0; i < _escales.Count; i++)
            {
                int placesDispoCabane = _escales[i].Cabane.Capacite;
                if (placesDispoCabane < places)
                {
                    places = placesDispoCabane;
                }
            }

            return places;
        }

        public int PlacesDisponibles()
        {
            int places = 200000;

            for (int i = 0; i < _escales.Count; i++)
            {
                int placesDispoCabane = _escales[i].Cabane.Capacite - NbMembresInscrits();
                if(placesDispoCabane < places)
                {
                    places = placesDispoCabane;
                }
            }

            return places;
        }

        public bool EstComplet()
        {
            return PlacesDisponibles() <= 0;
        }

        public void AjouterInscrit(Membre inscrit)
        {
            if(inscrit != null)
            {
                _inscrits.Add(inscrit);
            }
        }

        public List<Membre> RechercherInscrits()
        {
            List<Membre> inscrits = new List<Membre>();

            foreach (Membre inscr in _inscrits)
            {
                inscrits.Add(inscr);
            }

            return inscrits;
        }

        public List<Escale> RechercherEscales()
        {
            List<Escale> escales = new List<Escale>();

            foreach (Escale esc in _escales)
            {
                escales.Add(esc);
            }

            return escales;
        }

        public override string ToString()
        {
            return "Sortie '"+ Nom +"' ("+ NbMembresInscrits() +" inscrits / "+ MaxPlaces() +" places = "+ PlacesDisponibles() +" places disponibles), prix total: "+ CalculPrix() +" CHF";
        }
    }
}
