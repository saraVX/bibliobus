 using System;

namespace BiblioBus
{
    class DemoLivre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Demo de la classe Livre ===\n");

            // Création d'un livre sans trop se prendre la tete
            Console.WriteLine("1. Livre sans genre:");
            Livre livre1 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Console.WriteLine(livre1.ToString());
            Console.WriteLine();

            // Création d'un livre avec genre
            Console.WriteLine("2. Livre avec genre:");
            Livre livre2 = new Livre("1984", "George Orwell", "Penguin", "Science-fiction");
            Console.WriteLine(livre2.ToString());
            Console.WriteLine();

            // Ajout d'exemplaires
            Console.WriteLine("3. Ajouter des exemplaires:");
            livre1.NouvelleExemplaire(); 
            livre1.NouvelleExemplaire(3); 
            Console.WriteLine("Exemplaires maintenant: " + livre1.NbExemplaires);
            Console.WriteLine("Est present? " + livre1.EstPresent());
            Console.WriteLine();

            // Perte d'un exemplaire
            Console.WriteLine("4. Perte d'exemplaire:");
            livre1.PerteExemplaire();
            Console.WriteLine("Exemplaires restants: " + livre1.NbExemplaires);
            Console.WriteLine();

            // Test égalité
            Console.WriteLine("5. Test égalité:");
            Livre livre3 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Livre livre4 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Hachette");
            
            Console.WriteLine("livre1 == livre3? " + livre1.Equals(livre3)); 
            Console.WriteLine("livre1 == livre4? " + livre1.Equals(livre4)); 
            Console.WriteLine();

            // Changement d'editeur
            Console.WriteLine("6. Changer l'éditeur:");
            Livre livre5 = livre1.NouvelleEditeur("Éditions du Seuil");
            Console.WriteLine("Voilà le nouveau livre:");
            Console.WriteLine(livre5.ToString());
            Console.WriteLine();

            // Livre sans exemplaires, 
            Console.WriteLine("7. Livre sans exemplaire:");
            Livre livre6 = new Livre("Madame Bovary", "Gustave Flaubert", "Larousse");
            Console.WriteLine("Est present? " + livre6.EstPresent());
            Console.WriteLine();

            Console.WriteLine("=== Fin demo ===");
        }
    }
}
