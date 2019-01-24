using System;
using System.Collections.Generic;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void printMatrix(char[,] tempMatrix)
        {
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    Console.Write($"{tempMatrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static int CountOfKinght (char[,] tempMatrix, int currentRow, int currentCol)
        {
            int dimRow = tempMatrix.GetLength(0);
            int dimCol = tempMatrix.GetLength(1);
            List<int[]> combination = new List<int[]>
            {
                new int[] {1,2},
                new int[] {-1,2},
                new int[] {1,-2},
                new int[] {-1,-2},
                new int[] {2,1},
                new int[] {-2,1},
                new int[] {2,-1},
                new int[] {-2,-1}
            };
            int result=0;
            foreach (int[] position in combination)
            {
                int ofsetRow = position[0];
                int ofsetCol = position[1];
                int positionRow = currentRow + ofsetRow;
                int positionCol = currentCol + ofsetCol;

                if (positionRow<dimRow&&positionRow>=0&&
                    positionCol < dimCol && positionCol >= 0&&
                    tempMatrix[currentRow, currentCol] !='0')
                {
                    if (tempMatrix[positionRow, positionCol] != '0')
                    {
                        result++;
                    } 
                }
            }
            return result;
        }
        static void Main(string[] args)
        {

            int dimentions = int.Parse(Console.ReadLine());

            char[,] matrix = new char[dimentions, dimentions];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] readRow = Console.ReadLine().ToArray();
                    
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            //printMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int CountCollision = CountOfKinght(matrix, i, j);
                    if (CountCollision!=0)
                    {
                        matrix[i, j] = char.Parse(CountCollision.ToString());
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            printMatrix(matrix);
            matrix[2, 2] = '0';
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int CountCollision = CountOfKinght(matrix, i, j);
                    if (CountCollision != 0)
                    {
                        matrix[i, j] = char.Parse(CountCollision.ToString());
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            printMatrix(matrix);


        }
    }
}
