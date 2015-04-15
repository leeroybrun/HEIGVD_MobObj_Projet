using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Cabane
    {
        private string _nom;
        private Club _club;
        private string _latitude;
        private string _longitude;
        private int _capacite;
        private float _prixNuitee;
    
        public Cabane(string nom, string latitude, string longitude, int capacite, float prixNuitee, Club club)
        {
            Nom = nom;
            Latitude = latitude;
            Longiture = longitude;
            Capacite = capacite;
            PrixNuitee = prixNuitee;
            Club = club;
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

        public string Latitude
        {
            get
            {
                return _latitude;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "La latitude n'est pas valide.");
                }

                _latitude = value;
            }
        }

        public string Longiture
        {
            get
            {
                return _longitude;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "La longitude n'est pas valide.");
                }

                _longitude = value;
            }
        }

        public int Capacite
        {
            get
            {
                return _capacite;
            }
            set
            {
                // Pas de cabanes de moins de 2 places
                if (value < 2)
                {
                    throw new ArgumentNullException("value", "La capacité n'est pas valide.");
                }

                _capacite = value;
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

        public float PrixNuitee
        {
            get
            {
                return _prixNuitee;
            }
            set
            {
                // Prix peut être gratuit, mais pas négatif
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "Le prix de nuitée n'est pas valide.");
                }

                _prixNuitee = value;
            }
        }
    }
}
