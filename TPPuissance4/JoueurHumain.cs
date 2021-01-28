using System;
using System.Collections.Generic;
using System.Text;

namespace TPPuissance4
{
    public class JoueurHumain : Joueur
    {
        public JoueurHumain(string name,char jeton)
            :base(name,jeton)
        {

        }
        public override void Jouer(Grille grille)
        {
            base.Jouer(grille);
            
            int colonne = GetColonne();
            if (colonne > 6 || colonne < 0)
            {
                colonne = 0;
                Console.WriteLine("erreur");
                GetColonne();
            }
            else;
            int ligne = grille.GetLigne(colonne);
            if (ligne < 0)
            {
                Console.WriteLine("Erreur ,colonne pleine");
                colonne= GetColonne();
                ligne = grille.GetLigne(colonne);
            }   
            grille.Positionner(ligne, colonne, Jeton);
            if(grille.TestGagner() == true)
            {
                grille.Afficher();
                Console.WriteLine("Bravo {0} a gagné", Name);
            }




        }

    }
}
