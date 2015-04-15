using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HEIGVD_MobObj_Projet_Source
{
    public class GestionSorties
    {
        private List<Cabane> _cabanes = new List<Cabane>();
        private List<Club> _clubs = new List<Club>();
        private List<Membre> _membres = new List<Membre>();
        private List<Responsable> _responsables = new List<Responsable>();
    
        public GestionSorties()
        {
            
        }

        public void AjouterCabane(Cabane cabane)
        {
            if(cabane != null)
            {
                _cabanes.Add(cabane);
            }
        }

        public void AjouterClub(Club club)
        {
            if (club != null)
            {
                _clubs.Add(club);
            }
        }

        public void AjouterMembre(Membre membre)
        {
            if (membre != null)
            {
                _membres.Add(membre);
            }
        }

        public void AjouterResponsable(Responsable resp)
        {
            if (resp != null)
            {
                _responsables.Add(resp);
            }
        }
    }
}
