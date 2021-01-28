using System;
using System.Collections.Generic;
using System.Text;

namespace TPPuissance4
{
    public class Joueur
    {
        protected string Name { get; set; }
        protected char Jeton { get; set; }
        protected Grille grille { get; set; }
        public Joueur()
        {

        }
        public Joueur(string name,char jeton)
        {
            Name = name;
            Jeton = jeton;
        }
        public virtual void Jouer (Grille grille)
        {
            grille.Afficher();

        }
        public int GetColonne()
        {
            Console.WriteLine("{0} choisissez une colonne: ",Name);
             int colonne = Convert.ToInt32(Console.ReadLine())-1;
            
             return colonne;
            
        }
        
    }
}
