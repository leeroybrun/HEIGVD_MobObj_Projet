using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEIGVD_MobObj_Projet_Source
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionSorties gestion = new GestionSorties();

            Adresse adr1 = new Adresse("Rue du temple", 12, 1000, "Lausanne");
            Adresse adr2 = new Adresse("Rue de la motte", 23, 1000, "Lausanne");
            Adresse adr3 = new Adresse("Rue de la source", 34, 1000, "Lausanne");
            Adresse adr4 = new Adresse("Rue de la rivière", 1, 1000, "Lausanne");

            Responsable resp1 = new Responsable("Bernard", "Dupond", adr2);
            Responsable resp2 = new Responsable("Albert", "Franco", adr3);

            gestion.AjouterResponsable(resp1);
            gestion.AjouterResponsable(resp2);

            Club club1 = new Club("Les bons types", adr1, resp1);
            Club club2 = new Club("Copains d'avant", adr4, resp2);

            gestion.AjouterClub(club1);
            gestion.AjouterClub(club2);

            Membre membre1 = new Membre("Henry", "Chevalley", adr2);
            Membre membre2 = new Membre("Eric", "Salomon", adr3);
            Membre membre3 = new Membre("Paul", "Dupond", adr4);
            Membre membre4 = new Membre("Jaques", "Franco", adr1);
            Membre membre5 = new Membre("Patrick", "Patou", adr4);
            Membre membre6 = new Membre("Franck", "Dumont", adr2);

            gestion.AjouterMembre(membre1);
            gestion.AjouterMembre(membre2);
            gestion.AjouterMembre(membre3);
            gestion.AjouterMembre(membre4);
            gestion.AjouterMembre(membre5);
            gestion.AjouterMembre(membre6);

            Cabane cabane1 = new Cabane("Cabane du petit oiseaz", "...", "...", 2, 0, club1);
            Cabane cabane2 = new Cabane("Cabane du petit loup", "...", "...", 5, 10, club1);
            Cabane cabane3 = new Cabane("Cabane du petit chat", "...", "...", 10, 5, club2);
            Cabane cabane4 = new Cabane("Cabane du petit chien", "...", "...", 3, 20, club2);
            Cabane cabane5 = new Cabane("Cabane du petit renard", "...", "...", 20, 0, club2);
            
            gestion.AjouterCabane(cabane1);
            gestion.AjouterCabane(cabane2);
            gestion.AjouterCabane(cabane3);
            gestion.AjouterCabane(cabane4);
            gestion.AjouterCabane(cabane5);

            Sortie sortie1 = new Sortie("Promenade du dimanche", membre1, adr1, new DateTime(2015, 04, 20, 12, 0, 0), 0, club1);
            sortie1.AjouterEscale(new Escale(cabane1, new DateTime(2015, 04, 20, 18, 0, 0), new DateTime(2015, 04, 21, 6, 0, 0), sortie1));
            sortie1.AjouterEscale(new Escale(cabane2, new DateTime(2015, 04, 21, 20, 0, 0), new DateTime(2015, 04, 23, 8, 0, 0), sortie1));

            Sortie sortie2 = new Sortie("Promenade du lundi", membre4, adr2, new DateTime(2015, 04, 22, 12, 0, 0), 0, club2);
            sortie2.AjouterEscale(new Escale(cabane3, new DateTime(2015, 04, 20, 18, 0, 0), new DateTime(2015, 04, 21, 6, 0, 0), sortie2));
            sortie2.AjouterEscale(new Escale(cabane4, new DateTime(2015, 04, 21, 20, 0, 0), new DateTime(2015, 04, 23, 8, 0, 0), sortie2));
            sortie2.AjouterEscale(new Escale(cabane5, new DateTime(2015, 04, 23, 18, 0, 0), new DateTime(2015, 04, 24, 6, 0, 0), sortie2));

            club1.AjouterSortie(sortie1);
            club2.AjouterSortie(sortie2);

            // Inscription des membres au premier club
            Inscription inscr1 = membre1.InscriptionClub(club1);
            resp1.ValideInscription(inscr1);
            
            Inscription inscr2 = membre2.InscriptionClub(club1);
            resp1.ValideInscription(inscr2);
            
            Inscription inscr3 = membre3.InscriptionClub(club1);
            resp1.ValideInscription(inscr3);
            
            Inscription inscr4 = membre4.InscriptionClub(club1);
            
            // Inscription des membres au deuxième club
            Inscription inscr5 = membre5.InscriptionClub(club2);
            resp2.ValideInscription(inscr5);
            
            Inscription inscr6 = membre5.InscriptionClub(club2);
            
            Inscription inscr7 = membre4.InscriptionClub(club2);
            resp2.ValideInscription(inscr7);

            Inscription inscr8 = membre2.InscriptionClub(club2);
            resp2.ValideInscription(inscr8);

            // Affichage des membres des clubs
            Console.WriteLine("Inscriptions du club 1:");
            foreach (Inscription ins in club1.RechercherInscriptions())
            {
                Console.WriteLine(ins);
            }

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            Console.WriteLine("Inscriptions du club 2:");
            foreach (Inscription ins in club2.RechercherInscriptions())
            {
                Console.WriteLine(ins);
            }

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            // Inscription à une sortie
            membre1.InscriptionSortie(sortie1);
            membre2.InscriptionSortie(sortie1);

            // Affichage des infos de la sortie
            Console.WriteLine(sortie1);
            foreach (Escale esc in sortie1.RechercherEscales())
            {
                Console.WriteLine(esc);
            }

            Console.WriteLine("Sortie 1 complète ? " + sortie1.EstComplet());

            if(!sortie1.EstComplet())
            {
                membre3.InscriptionSortie(sortie1);
            } else {
                Console.WriteLine("La sortie est complète ! On ne peut pas ajouter de nouveau membre.");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            Console.WriteLine("Affichage des sorties disponibles pour le membre "+ membre2);
            foreach (Sortie sortie in membre2.RechercherSortiesClubs())
            {
                Console.WriteLine(sortie);
            }

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            Console.WriteLine("Affichage des sorties disponibles pour le membre " + membre1);
            foreach (Sortie sortie in membre1.RechercherSortiesClubs())
            {
                Console.WriteLine(sortie);
            }

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            Console.WriteLine("Affichage des sorties disponibles pour le membre " + membre4);
            foreach (Sortie sortie in membre4.RechercherSortiesClubs())
            {
                Console.WriteLine(sortie);
            }

            Console.ReadKey();
        }
    }
}
