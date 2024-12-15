using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFormatifFinal
{
    public class GenerateurCadeau
    {
        //Déclaration de la Taille du cadeau
        public int taille;

        // Déclaration d'un Tableau de type string avec les couleurs possibles
       public string[] couleurs;

        // Déclaration de la Couleur du tableau
        public string couleur;

        //Ajouter le constructeur de la classe
        public  GenerateurCadeau() 
        {
            // Initialisation du tableau avec les différentes couleurs appropiées
            this.couleurs = new string[] {"Rouge","Vert","Doré","Argenté" };

            //Initialiser un premier cadeau de taille moyenne et de couleur doré 
            this.taille = 1;
            this.couleur = "Doré";
        }

        // Ajouter la methode genererCadeau aleatoire
        public void generCadeau() 
        {
            // Declaration d'un nombre aleatoire 
            Random rng = new Random();

            //choisir une couleur aleatoire dans le tableau couleurs
            this.couleur = couleurs[rng.Next(couleurs.Length)];

            this.taille = rng.Next(0, 4);


        
        }
        public void remplirListeCadeau() 
        {
        
        
        }

    }
}
