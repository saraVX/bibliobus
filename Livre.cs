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

        
        public string Titre => titre;
        public string Auteur => auteur;
        public string Editeur => editeur;
        public int NbExemplaires => nbExemplaires;
        public string Genre => genre;

        
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

        
        public override string ToString()
        {
            return $"Titre: {titre}\n" +
                   $"Auteur: {auteur}\n" +
                   $"Éditeur: {editeur}\n" +
                   $"Genre: {genre}\n" +
                   $"Exemplaires disponibles: {nbExemplaires}";
        }

        
        public bool EstPresent()
        {
            return nbExemplaires > 0;
        }

        
        public bool Equals(Livre autre)
        {
            if (autre == null) return false;
            
            return titre == autre.titre && 
                   auteur == autre.auteur && 
                   editeur == autre.editeur;
        }

        
        public Livre NouvelleEditeur(string nouvelEditeur)
        {
            if (string.IsNullOrWhiteSpace(nouvelEditeur))
                throw new ArgumentNullException(nameof(nouvelEditeur));
            
            return new Livre(titre, auteur, nouvelEditeur, genre);
        }
    }
}
