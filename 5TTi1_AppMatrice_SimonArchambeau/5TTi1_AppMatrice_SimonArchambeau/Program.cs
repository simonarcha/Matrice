using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTi1_AppMatrice_SimonArchambeau
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrices MesOutils = new Matrices();
            bool suivi = true;
            while (suivi)
            {
                Console.WriteLine("Bienvenue dans mon programme Matrice !");
                Console.WriteLine("Tapez 1 pour transposer une matrice");
                Console.WriteLine("Tapez 2 pour la deuxième fonction");
                Console.WriteLine("Tapez 3 pour quitter");
                String choix = Console.ReadLine();
                switch (choix)     // Match Expression - can be any non-null expression
                {
                    case "1":             // choix de la transposition
                        int[,] t;
                        int[,] At;
                        int lignes = 0;
                        int colonnes = 0;
                        String StTab = "";
                        MesOutils.LireInteger("Entrez le nombre de ligne de la matrice ", out lignes);
                        MesOutils.LireInteger("Entrez le nombre de colonne de la matrice ", out colonnes);
                        MesOutils.Matrice_tab_alea(lignes, colonnes, out t);
                        MesOutils.Matrice_concatenation(t, out StTab);
                        Console.WriteLine(StTab);
                        MesOutils.Matrice_Transposition(t, out At);
                        MesOutils.Matrice_concatenation(At, out StTab);
                        Console.WriteLine("Matrice transposée : ");
                        Console.WriteLine(StTab);
                        break;
                    case "2":             //Choix de la seconde option
                                        // ...
                        break;          
                    case "3":
                        suivi = false;                
                        break;          
                    default:
                        Console.WriteLine("Option non valide");             
                        break;          
                }
            }
        }
    }
}
