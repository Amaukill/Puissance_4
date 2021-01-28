using System;
using System.Collections.Generic;
using System.Text;

namespace TPPuissance4
{
    public class Puissance4 : Jeu
    {
        Jeu Jeu { get; set; }
        public Puissance4() { }
        public Puissance4(Jeu jeu)
        {
            Jeu = jeu;
        }

        public void Demarrer()
        {

            Console.WriteLine("Choisissez votre mode de jeu :");
            Console.WriteLine("[1] 2 Joueurs");
            Console.WriteLine("[2] 1 Joueur vs IA");
            Console.WriteLine("[3] Quitter");
            int mode = Convert.ToInt32(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    Console.WriteLine("Entrer votre nom Joueur 1:");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Entrer votre nom Joueur 2:");
                    string name2 = Console.ReadLine();
                    JoueurHumain joueur1 = new JoueurHumain(name1, 'X');
                    JoueurHumain joueur2 = new JoueurHumain(name2, 'O');
                    Jeu2Joueurs(joueur1, joueur2);
                    break;
                case 2:
                    Console.WriteLine("Entrer votre nom :");
                    string name = Console.ReadLine();
                    JoueurHumain joueur = new JoueurHumain(name, 'X');
                    JeuIA(joueur);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("erreur");
                    Demarrer();
                    break;
            }


        }
        public void Jeu2Joueurs(JoueurHumain joueur1, JoueurHumain joueur2)
        {
            Grille grille = new Grille();
            grille.Init();

            for (int i = 0; i < 21; i++)
            {
                joueur1.Jouer(grille);
                if (grille.TestGagner() == true)
                {
                   
                    Rejouer2J(joueur1, joueur2);
                    break;
                }
                joueur2.Jouer(grille);
                if (grille.TestGagner() == true)
                {
                    Rejouer2J(joueur1, joueur2);
                    break;
                }


            }
            Console.WriteLine("Match Nul !!");
            Rejouer2J(joueur1, joueur2);
        }
        public void JeuIA(JoueurHumain joueur)
        {

            JoueurIA IA = new JoueurIA('O');
            Grille grille = new Grille();
            grille.Init();
            for (int i = 0; i < 21; i++)
            {
                joueur.Jouer(grille);
                if (grille.TestGagner() == true)
                {
                    Rejouer1J(joueur);
                    break;
                }
                IA.Jouer(grille);
                if (grille.TestGagner() == true)
                {
                    Rejouer1J(joueur);
                    break;
                }
            }
        }
        public void Rejouer2J(JoueurHumain joueur1, JoueurHumain joueur2)
        {
            Console.WriteLine("Voulez-vous rejouer ?(y/n)");
            string rejouer = Console.ReadLine();
            switch (rejouer)
            {
                case "y":
                    Jeu2Joueurs(joueur1, joueur2);
                    break;
                case "n":
                    Demarrer();
                    break;
                default:
                    Demarrer();
                    break;
            }
        }
        public void Rejouer1J(JoueurHumain joueur)
        {
            Console.WriteLine("Voulez-vous rejouer ?(y/n)");
            string rejouer = Console.ReadLine();
            switch (rejouer)
            {
                case "y":
                    JeuIA(joueur);
                    break;
                case "n":
                    Demarrer();
                    break;
                default:
                    Demarrer();
                    break;
            }
        }
    }
}
