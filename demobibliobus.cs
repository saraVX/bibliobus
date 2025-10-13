 using System;

namespace BiblioBus
{
    public class DemoBibliobus
    {
        public static void Main(string[] args)
        {
            Bibliobus monBus = new Bibliobus("Bibliobus Central", 10);

            monBus.AjouterLivre("Harry Potter", "J.K. Rowling", "Gallimard", "Jeunesse");
            monBus.AjouterLivre("1984", "George Orwell", "Penguin", "Science-fiction");
            monBus.AjouterLivre("Le Petit Prince", "Saint-Exupéry", "Gallimard", "Jeunesse");

            Console.WriteLine("--- CATALOGUE COMPLET ---");
            monBus.AfficherCatalogue();
            Console.WriteLine();

            monBus.AcheterExemplaires(0, 3);
            monBus.AcheterExemplaires(1, 2);

            Console.WriteLine("--- LIVRES PRÉSENTS ---");
            monBus.AfficherLivresPresents();
            Console.WriteLine();

            Console.WriteLine("--- LIVRES JEUNESSE ---");
            monBus.AfficherParGenre("Jeunesse");
            Console.WriteLine();

            monBus.SupprimerLivre(1);
            Console.WriteLine("--- APRÈS SUPPRESSION ---");
            monBus.AfficherCatalogue();
        }
    }
}
