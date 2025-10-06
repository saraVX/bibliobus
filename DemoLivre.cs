using System;

namespace BiblioBus
{
    class DemoLivre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Démonstration de la classe Livre ===\n");

            // Test du constructeur de base
            Console.WriteLine("1. Création d'un livre sans genre spécifié:");
            Livre livre1 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Console.WriteLine(livre1.ToString());
            Console.WriteLine();

            // Test du constructeur avec genre
            Console.WriteLine("2. Création d'un livre avec genre:");
            Livre livre2 = new Livre("1984", "George Orwell", "Penguin", "Science-fiction");
            Console.WriteLine(livre2.ToString());
            Console.WriteLine();

            // Test des méthodes d'ajout d'exemplaires
            Console.WriteLine("3. Ajout d'exemplaires:");
            livre1.NouvelleExemplaire(); // Ajout d'un seul exemplaire
            livre1.NouvelleExemplaire(3); // Ajout de plusieurs exemplaires
            Console.WriteLine($"Exemplaires après ajout: {livre1.NbExemplaires}");
            Console.WriteLine($"Le livre est présent: {livre1.EstPresent()}");
            Console.WriteLine();

            // Test de la perte d'exemplaire
            Console.WriteLine("4. Perte d'un exemplaire:");
            livre1.PerteExemplaire();
            Console.WriteLine($"Exemplaires après perte: {livre1.NbExemplaires}");
            Console.WriteLine();

            // Test de la méthode equals
            Console.WriteLine("5. Test d'égalité:");
            Livre livre3 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard");
            Livre livre4 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Hachette");
            
            Console.WriteLine($"livre1 equals livre3: {livre1.Equals(livre3)}"); // Devrait être true
            Console.WriteLine($"livre1 equals livre4: {livre1.Equals(livre4)}"); // Devrait être false
            Console.WriteLine();

            // Test du changement d'éditeur
            Console.WriteLine("6. Changement d'éditeur:");
            Livre livre5 = livre1.NouvelleEditeur("Éditions du Seuil");
            Console.WriteLine("Nouveau livre avec nouvel éditeur:");
            Console.WriteLine(livre5.ToString());
            Console.WriteLine();

            // Test avec un livre sans exemplaires
            Console.WriteLine("7. Livre sans exemplaires:");
            Livre livre6 = new Livre("Madame Bovary", "Gustave Flaubert", "Larousse");
            Console.WriteLine($"Le livre est présent: {livre6.EstPresent()}");
            Console.WriteLine();

            Console.WriteLine("=== Fin de la démonstration ===");
        }
    }
}
