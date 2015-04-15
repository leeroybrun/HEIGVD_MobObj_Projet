using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class Responsable : Membre
    {
        public Responsable(string nom, string prenom, Adresse adresse) : base(nom, prenom, adresse)
        {

        }

        public void ValideInscription(Inscription inscription)
        {
            if(inscription.Club.Responsable == this)
            {
                inscription.Etat = EtatInscription.Validee;
            }
        }
    }
}
