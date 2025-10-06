 using System;

namespace BiblioBus
{
    class DemoLivre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Demo de la classe Livre ===\n");

            // création d'un livre sans genre
            Console.WriteLine("1. Création d'un livre sans genre:");
            Livre livre1 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Console.WriteLine(livre1.ToString());
            Console.WriteLine();

            // création avec genre
            Console.WriteLine("2. Création d'un livre avec un genre:");
            Livre livre2 = new Livre("1984", "George Orwell", "Penguin", "Science-fiction");
            Console.WriteLine(livre2.ToString());
            Console.WriteLine();

            // ajout d'exemplaires
            Console.WriteLine("3. Ajout d'exemplaires");
            livre1.NouvelleExemplaire(); // juste 1
            livre1.NouvelleExemplaire(3); // oups 3 de plus
            Console.WriteLine("Nombre d'exemplaires maintenant: " + livre1.NbExemplaires);
            Console.WriteLine("Est-ce qu'il est présent ? " + livre1.EstPresent());
            Console.WriteLine();

            // perte d'exemplaire
            Console.WriteLine("4. Perte d'un exemplaire...");
            livre1.PerteExemplaire();
            Console.WriteLine("Exemplaires après la perte: " + livre1.NbExemplaires);
            Console.WriteLine();

            // test d'égalité
            Console.WriteLine("5. Test d'égalité:");
            Livre livre3 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Livre livre4 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Hachette");

            Console.WriteLine("livre1 == livre3 ? " + livre1.Equals(livre3)); // normalement true
            Console.WriteLine("livre1 == livre4 ? " + livre1.Equals(livre4)); // normalement false
            Console.WriteLine();

            // changer d'éditeur
            Console.WriteLine("6. Changement d'éditeur");
            Livre livre5 = livre1.NouvelleEditeur("Éditions du Seuil");
            Console.WriteLine("Voilà le nouveau livre:");
            Console.WriteLine(livre5.ToString());
            Console.WriteLine();

            // livre sans exemplaire
            Console.WriteLine("7. Livre sans exemplaires");
            Livre livre6 = new Livre("Madame Bovary", "Gustave Flaubert", "Larousse");
            Console.WriteLine("Est-ce présent ? " + livre6.EstPresent());
            Console.WriteLine();

            Console.WriteLine("=== Fin du demo ===");
        }
    }
}
