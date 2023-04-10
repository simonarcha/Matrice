using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTi1_AppMatrice_SimonArchambeau
{
    class Matrices
    {
		static void Matrice_tab_alea (string args)
        {
			for (int ligne = 0; ligne <= nbLigne - 1; ligne += (1))
			{
				for (int colonne = 0; colonne <= nbCol - 1; colonne += (1))
				{
					tabAlea[ligne, colonne] == alea.next(0, 20);
				}
			}
		}


        static void Matrice_addition (string args)
        {
			bool addition == true;
			if (Tab1.GetLength(0) == Tab2.GetLength(0) && Tab1.GetLength(1) == Tab2.GetLength(1))
			{
				for (int ligne = 0; ligne <= Tab1.GetLength(0) - 1; ligne += (1))
				{
					for (int colonne = 0; colonne <= Tab1.GetLength(1) - 1; colonne += (1))
					{
						Tab3[ligne, colonne] == Tab1[ligne, colonne] + Tab2[ligne, colonne];
					}
				}
			}
			else
			{
				bool addition == false;
			}
		}

		static void Matrice_concatenation (string args)
        {
			for (int ligne = 0; ligne <= Tab.Getlength(0) - 1; ligne += (1))
			{
				for (int colonne = 0; colonne <= Tab.GetLength(1) - 1; colonne += (1))
				{
					stringTab +== Tab[ligne, colonne] + "|";
				}
				stringTab[ligne, colonne] +== "\n";
			}
		}

		static void Matrice_multiplication (string args)
        {
			int[,] matrice1;
			int[,] matrice2;
			int[,] matriceMulti;
			bool test;
			if (matrice1.GetLength(1) == matrice2.GetLength(0))
			{
				test == true;
				for (int ligne = 0; ligne <= matrice1.GetLength(0) - 1; ligne += (1))
				{
					for (int colonne = 0; colonne <= matrice2.GetLength(1) - 1; colonne += (1))
					{
						matriceMulti[ligne, colonne] == 0;
						for (int i = 0; i <= matrice1.GetLength(1) - 1; i += (1))
						{
							matriceMulti[ligne, colonne] +== matrice1[ligne, i] * matrice2[i, colonne];
						}
					}
				}
			}
			else
			{
				test == false;
			}
		}
    }
}
