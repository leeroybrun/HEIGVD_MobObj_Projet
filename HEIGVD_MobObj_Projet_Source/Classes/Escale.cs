using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Escale
    {
        private Cabane _cabane;
        private Sortie _sortie;
        private DateTime _dateArrivee;
        private DateTime _dateDepart;
    
        public Escale(Cabane cabane, DateTime dateArrivee, DateTime dateDepart, Sortie sortie)
        {
            Sortie = sortie;
            Cabane = cabane;
            DateArrivee = dateArrivee;
            DateDepart = dateDepart;
        }
    
        public DateTime DateArrivee
        {
            get
            {
                return _dateArrivee;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "La date d'arrivée n'est pas valide.");
                }

                _dateArrivee = value;
            }
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
                    throw new ArgumentNullException("value", "La date de départ n'est pas valide.");
                }

                _dateDepart = value;
            }
        }

        public Sortie Sortie
        {
            get
            {
                return _sortie;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "La sortie n'est pas valide.");
                }

                _sortie = value;
            }
        }

        public Cabane Cabane
        {
            get
            {
                return _cabane;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "La cabane n'est pas valide.");
                }

                _cabane = value;
            }
        }

        public float CalculPrix()
        {
            return (DateDepart - DateArrivee).Days * Cabane.PrixNuitee;
        }

        public override string ToString()
        {
            return "Escale à la cabane '"+ Cabane.Nom +"' ("+ Cabane.Capacite +" places) du "+ DateArrivee +" au "+ DateDepart +", prix de la nuit: "+ Cabane.PrixNuitee +" CHF, total: "+ CalculPrix() +" CHF";
        }
    }
}
