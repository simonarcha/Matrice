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
            int[,] t;
            String StTab;
            Console.WriteLine("Bienvenue dans mon programme Matrice !");
            Console.Write("Veuillez saisir le nombre de lignes de la matrice : ");
            int lignes = int.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir le nombre de colonnes de la matrice : ");
            int colonnes = int.Parse(Console.ReadLine());
            MesOutils.Matrice_tab_alea(lignes, colonnes,out t);
            MesOutils.Matrice_concatenation(t, out StTab);
            Console.WriteLine(StTab);
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();

        }
    }
}
