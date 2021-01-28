using System;
using System.Collections.Generic;
using System.Text;

namespace TPPuissance4
{
    public class Grille
    {

        protected const int Ligne = 6;
        protected const int Colonne = 7;
        protected char[,] grille = new char[Ligne, Colonne];
        public Grille() { }
        public void Init()
        {

            for (int i = 0; i < Ligne; i++)
            {
                for (int j = 0; j < Colonne; j++)
                {
                    grille[i, j] = ' ';

                }
            }

        }
        public void Afficher()
        {
            Console.Clear();
            Console.WriteLine("+ 1 + 2 + 3 + 4 + 5 + 6 + 7 +");
            Console.WriteLine("+---+---+---+---+---+---+---+");
            for (int i = 0; i < Ligne; i++)
            {

                for (int j = 0; j < Colonne; j++)
                {

                    Console.Write("| {0} ", grille[i, j]);

                }
                Console.Write("|");
                Console.WriteLine(" ");
                Console.WriteLine("+---+---+---+---+---+---+---+");
            }
        }
        public void Positionner(int ligne,int colonne ,char jeton) 
        {
           
            grille[ligne, colonne ] = jeton;
            
        }
        public int GetLigne(int colonne)
        {
            int ligne = 0;
            for(int i =0; i < Ligne; i++)
            {
                if (grille[i, colonne ] == ' ')
                {
                    ligne++;
                    continue;
                }
                else if (grille[i, colonne ] == 'X' || grille[i, colonne ] == 'O')
                {
                    ligne = i--;
                    break;
                }
            }
            
             return ligne-1;
        }
        public bool TestGagner()
        {
           
            for (int j = 0; j < 4; j++) 
            {
                for (int i = 0; i < 3 ; i++)
                {
                    if (grille[i, j] != ' ' && grille[i, j] == grille[i + 1, j + 1] && grille[i, j] == grille[i + 2, j + 2] && grille[i, j] == grille[i + 3, j + 3])
                        return true;

                }
            }
            for (int j = 3; j < 7; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (grille[i, j] != ' ' && grille[i, j] == grille[i + 1, j - 1] && grille[i, j] == grille[i + 2, j - 2] && grille[i, j] == grille[i + 3, j - 3])
                        return true;

                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (grille[i, j] != ' ' && grille[i, j] == grille[i , j + 1] && grille[i, j] == grille[i , j + 2] && grille[i, j] == grille[i , j +3])
                        return true;

                }
            }
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (grille[i, j] != ' ' && grille[i, j] == grille[i+1, j ] && grille[i, j] == grille[i+2, j] && grille[i, j] == grille[i+3, j])
                        return true;

                }
            }
           
            return false;
        }
        public int Selection()
        {
            
            int[]Score= new int [Colonne];
            int ScoreMax = 0;
            for (int j = 0; j < 7; j++)
            {
                int compteur = 0;
                for (int i = 5; i>=2 ; i--)
                {
                    if (grille[i, j] != ' ' && grille[i, j] == grille[i - 1, j ] && grille[i, j] == grille[i - 2, j])
                    {
                        compteur = 4;
                    }
                    else if (grille[i, j] != ' ' && grille[i, j] == grille[i - 1, j])
                    {
                        compteur = 3;
                    }
                    else if (grille[i, j] != ' ')
                    {
                        compteur = 2;
                    }
                    
                }
                Score[j] = compteur;
            }
            for(int i = 0; i < 7; i++)
            {
                int compteur = 0;
                
                if (Score[i] > compteur)
                {
                    compteur = Score[i];
                    ScoreMax = i;
                    continue;
                }
            }
           
            return ScoreMax;
        }
    }
}
