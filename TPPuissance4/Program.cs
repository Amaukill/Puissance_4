using System;

namespace TPPuissance4
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu Puissance4 = new Jeu("Puissance4");
            Puissance4 jeu = new Puissance4(Puissance4);
            jeu.Demarrer();
        }
    }
}
