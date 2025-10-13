 using System;

namespace BiblioBus
{
    class DemoLivre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Demo de la classe Livre ===\n");

            
            Console.WriteLine("1. Livre sans genre:");
            Livre livre1 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Console.WriteLine(livre1.ToString());
            Console.WriteLine();

            
            Console.WriteLine("2. Livre avec genre:");
            Livre livre2 = new Livre("1984", "George Orwell", "Penguin", "Science-fiction");
            Console.WriteLine(livre2.ToString());
            Console.WriteLine();

            
            Console.WriteLine("3. Ajouter des exemplaires:");
            livre1.NouvelleExemplaire(); 
            livre1.NouvelleExemplaire(3); 
            Console.WriteLine("Exemplaires maintenant: " + livre1.NbExemplaires);
            Console.WriteLine("Est present? " + livre1.EstPresent());
            Console.WriteLine();

           
            Console.WriteLine("4. Perte d'exemplaire:");
            livre1.PerteExemplaire();
            Console.WriteLine("Exemplaires restants: " + livre1.NbExemplaires);
            Console.WriteLine();

           
            Console.WriteLine("5. Test égalité:");
            Livre livre3 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Livre livre4 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Hachette");
            
            Console.WriteLine("livre1 == livre3? " + livre1.Equals(livre3)); 
            Console.WriteLine("livre1 == livre4? " + livre1.Equals(livre4)); 
            Console.WriteLine();

           
            Console.WriteLine("6. Changer l'éditeur:");
            Livre livre5 = livre1.NouvelleEditeur("Éditions du Seuil");
            Console.WriteLine("Voilà le nouveau livre:");
            Console.WriteLine(livre5.ToString());
            Console.WriteLine();

            
            Console.WriteLine("7. Livre sans exemplaire:");
            Livre livre6 = new Livre("Harry potter", "J.K. Rowling", "jeunesse");
            Console.WriteLine("Est present? " + livre6.EstPresent());
            Console.WriteLine();

            Console.WriteLine("=== Fin demo ===");
        }
    }
}
