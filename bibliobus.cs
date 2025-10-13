 using System;

namespace BiblioBus
{
    public class Bibliobus
    {
        private string nom;
        private Livre[] catalogue;
        private int nbLivres;

        public Bibliobus(string nom, int taille)
        {
            this.nom = nom;
            this.catalogue = new Livre[taille];
            this.nbLivres = 0;
        }

        public string Nom
        {
            get { return nom; }
        }

        public int Capacite
        {
            get { return catalogue.Length; }
        }

        public int NbLivres
        {
            get { return nbLivres; }
        }

        public bool AjouterLivre(string titre, string auteur, string editeur)
        {
            if (nbLivres < catalogue.Length)
            {
                catalogue[nbLivres] = new Livre(titre, auteur, editeur);
                nbLivres++;
                return true;
            }
            return false;
        }

        public bool AjouterLivre(string titre, string auteur, string editeur, string genre)
        {
            if (nbLivres < catalogue.Length)
            {
                catalogue[nbLivres] = new Livre(titre, auteur, editeur, genre);
                nbLivres++;
                return true;
            }
            return false;
        }

        public void AfficherCatalogue()
        {
            Console.WriteLine("Catalogue du " + nom);
            Console.WriteLine("Livres: " + nbLivres + "/" + catalogue.Length);
            Console.WriteLine("------------------------");
            
            for (int i = 0; i < nbLivres; i++)
            {
                Console.WriteLine("ID: " + i);
                Console.WriteLine(catalogue[i].ToString());
                Console.WriteLine("-------------------");
            }
        }

        public void AfficherLivre(int id)
        {
            if (id >= 0 && id < nbLivres)
            {
                Console.WriteLine("Livre ID: " + id);
                Console.WriteLine(catalogue[id].ToString());
            }
            else
            {
                Console.WriteLine("ID invalide");
            }
        }

        public bool LivreExiste(int id)
        {
            return (id >= 0 && id < nbLivres);
        }

        public bool LivrePresent(int id)
        {
            if (LivreExiste(id))
            {
                return catalogue[id].EstPresent();
            }
            return false;
        }

        public void AcheterExemplaires(int id, int quantite)
        {
            if (LivreExiste(id) && quantite > 0)
            {
                catalogue[id].NouvelleExemplaire(quantite);
            }
        }

        public void SignalerPerte(int id)
        {
            if (LivreExiste(id))
            {
                catalogue[id].PerteExemplaire();
            }
        }

        public bool SupprimerLivre(int id)
        {
            if (!LivreExiste(id))
                return false;

            for (int i = id; i < nbLivres - 1; i++)
            {
                catalogue[i] = catalogue[i + 1];
            }
            
            catalogue[nbLivres - 1] = null;
            nbLivres--;
            return true;
        }

        public void AfficherLivresPresents()
        {
            Console.WriteLine("Livres présents dans " + nom + ":");
            bool aucunPresent = true;
            
            for (int i = 0; i < nbLivres; i++)
            {
                if (catalogue[i].EstPresent())
                {
                    Console.WriteLine("ID " + i + ": " + catalogue[i].Titre);
                    aucunPresent = false;
                }
            }
            
            if (aucunPresent)
                Console.WriteLine("Aucun livre présent");
        }

        public void AfficherParGenre(string genre)
        {
            Console.WriteLine("Livres du genre '" + genre + "':");
            bool aucunTrouve = true;
            
            for (int i = 0; i < nbLivres; i++)
            {
                if (catalogue[i].Genre.ToLower() == genre.ToLower())
                {
                    Console.WriteLine("ID " + i + ": " + catalogue[i].Titre);
                    aucunTrouve = false;
                }
            }
            
            if (aucunTrouve)
                Console.WriteLine("Aucun livre de ce genre");
        }
    }
}
