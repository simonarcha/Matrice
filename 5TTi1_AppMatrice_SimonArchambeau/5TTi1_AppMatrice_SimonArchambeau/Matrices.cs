using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTi1_AppMatrice_SimonArchambeau
{
    public struct Matrices
    {
		public void Matrice_tab_alea (int nbLigne, int nbCol, out int[,] tabAlea)
        {
			tabAlea = new int[nbLigne,nbCol];
            Random alea = new Random();
            for (int ligne = 0; ligne <= nbLigne - 1; ligne += (1))
			{
				for (int colonne = 0; colonne <= nbCol - 1; colonne += (1))
				{
					tabAlea[ligne, colonne] = alea.Next(0,20);
				}
			}
		}
        public void  Matrice_addition(int[,] Tab1, int[,] Tab2, out int[,] Tab3)
        {
			bool addition = true;
			Tab3 = new int[Tab1.GetLength(0), Tab1.GetLength(1)];
			if (Tab1.GetLength(0) == Tab2.GetLength(0) && Tab1.GetLength(1) == Tab2.GetLength(1))
			{
				for (int ligne = 0; ligne <= Tab1.GetLength(0) - 1; ligne += (1))
				{
					for (int colonne = 0; colonne <= Tab1.GetLength(1) - 1; colonne += (1))
					{
						Tab3[ligne, colonne] = Tab1[ligne, colonne] + Tab2[ligne, colonne];
					}
				}
			}
			else
			{
				addition = false;
			}
        }
		public void Matrice_concatenation (int[,] Tab, out String StTab)
        {
			StTab= null;
			for (int ligne = 0; ligne <= Tab.GetLength(0) - 1; ligne += (1))
			{
				for (int colonne = 0; colonne <= Tab.GetLength(1) - 1; colonne += (1))
				{
					StTab += Tab[ligne, colonne] + "|";
				}
				StTab += "\n";
			}
		}

		 public void Matrice_multiplication (int[,] matrice1, int[,] matrice2, out int[,] matriceMulti)
        {
			matriceMulti = new int[matrice1.GetLength(1), matrice2.GetLength(0)];
			bool test = true;
			if (matrice1.GetLength(1) == matrice2.GetLength(0))
			{
				test = true;
				for (int ligne = 0; ligne <= matrice1.GetLength(0) - 1; ligne += (1))
				{
					for (int colonne = 0; colonne <= matrice2.GetLength(1) - 1; colonne += (1))
					{
						matriceMulti[ligne, colonne] = 0;
						for (int i = 0; i <= matrice1.GetLength(1) - 1; i += (1))
						{
							matriceMulti[ligne, colonne] += matrice1[ligne, i] * matrice2[i, colonne];
						}
					}
				}
			}
			else
			{
				test = false;
			}
        }
    }
}
