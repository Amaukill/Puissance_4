using System;
using System.Collections.Generic;
using System.Text;

namespace TPPuissance4
{
    class JoueurIA : Joueur 
    {
        public JoueurIA (char jeton) 
        {
            Jeton = jeton;
        }
        public override void Jouer(Grille grille)
        {
            var rand = new Random();
            base.Jouer(grille);
            int colonne =grille.Selection();
            int ligne = grille.GetLigne(colonne);
            if (ligne< 0)
            {
                colonne = rand.Next(0, 7);
            }
            grille.Positionner(ligne, colonne, Jeton);
            if (grille.TestGagner() == true)
            {
                grille.Afficher();
                Console.WriteLine("L'IA a gagné");
            }
        }
       
    }
}
