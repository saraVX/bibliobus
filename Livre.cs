using System;

namespace BiblioBus
{
    public class Livre
    {
        
        private string titre;
        private string auteur;
        private string editeur;
        private int nbExemplaires;
        private string genre;

       
        public Livre(string titre, string auteur, string editeur)
        {
            this.titre = titre ?? throw new ArgumentNullException(nameof(titre));
            this.auteur = auteur ?? throw new ArgumentNullException(nameof(auteur));
            this.editeur = editeur ?? throw new ArgumentNullException(nameof(editeur));
            this.nbExemplaires = 0;
            this.genre = "Non spécifié";
        }

       
        public Livre(string titre, string auteur, string editeur, string genre)
        {
            this.titre = titre ?? throw new ArgumentNullException(nameof(titre));
            this.auteur = auteur ?? throw new ArgumentNullException(nameof(auteur));
            this.editeur = editeur ?? throw new ArgumentNullException(nameof(editeur));
            this.nbExemplaires = 0;
            this.genre = genre ?? "Non spécifié";
        }

        // Accesseurs en lecture (Exercice 3)
        public string Titre => titre;
        public string Auteur => auteur;
        public string Editeur => editeur;
        public int NbExemplaires => nbExemplaires;
        public string Genre => genre;

        // Méthodes pour les exemplaires (Exercice 4)
        public void NouvelleExemplaire()
        {
            nbExemplaires++;
        }

        public void NouvelleExemplaire(int nb)
        {
            if (nb < 0)
                throw new ArgumentException("Le nombre d'exemplaires ne peut pas être négatif");
            
            nbExemplaires += nb;
        }

        public void PerteExemplaire()
        {
            if (nbExemplaires > 0)
                nbExemplaires--;
            else
                throw new InvalidOperationException("Impossible de perdre un exemplaire : aucun exemplaire disponible");
        }

        // Méthode toString() (Exercice 5)
        public override string ToString()
        {
            return $"Titre: {titre}\n" +
                   $"Auteur: {auteur}\n" +
                   $"Éditeur: {editeur}\n" +
                   $"Genre: {genre}\n" +
                   $"Exemplaires disponibles: {nbExemplaires}";
        }

        // Méthode estPresent() (Exercice 6)
        public bool EstPresent()
        {
            return nbExemplaires > 0;
        }

        // Méthode equals() (Exercice 7)
        public bool Equals(Livre autre)
        {
            if (autre == null) return false;
            
            return titre == autre.titre && 
                   auteur == autre.auteur && 
                   editeur == autre.editeur;
        }

        // Méthode pour changement d'éditeur (Exercice 8)
        public Livre NouvelleEditeur(string nouvelEditeur)
        {
            if (string.IsNullOrWhiteSpace(nouvelEditeur))
                throw new ArgumentNullException(nameof(nouvelEditeur));
            
            return new Livre(titre, auteur, nouvelEditeur, genre);
        }
    }
}
