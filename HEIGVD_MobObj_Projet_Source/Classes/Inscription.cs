using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Inscription
    {
        private Membre _membre;
        private EtatInscription _etat;
        private Club _club;

        public Inscription(Membre membre, Club club, EtatInscription etat)
        {
            Membre = membre;
            Club = club;
            Etat = etat;
        }

        public EtatInscription Etat
        {
            get
            {
                return _etat;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("value", "L'état n'est pas valide.");
                }

                _etat = value;
            }
        }

        public Membre Membre
        {
            get
            {
                return _membre;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Le membre n'est pas valide.");
                }

                _membre = value;
            }
        }

        public Club Club
        {
            get
            {
                return _club;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Le club n'est pas valide.");
                }

                _club = value;
            }
        }

        public override string ToString()
        {
            string etat = "";
            if(Etat == EtatInscription.AttenteValidation)
            {
                etat = "Attente de validation";
            }
            else
            {
                etat = "Validée";
            }

            return Membre.Prenom +" "+ Membre.Nom +" inscrit au club "+ Club.Nom +" ("+ etat +")";
        }
    }
}
