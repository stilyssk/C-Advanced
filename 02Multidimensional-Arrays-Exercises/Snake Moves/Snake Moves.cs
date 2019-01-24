using System;
using System.Linq;

namespace Snake_Moves
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
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                                       .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();
            int row = dimentions[0];
            int column = dimentions[1];
            char[,] matrix = new char[row, column];
            string inputString = Console.ReadLine();
            int indexPositionString = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (indexPositionString==inputString.Length)
                    {
                        indexPositionString = 0;
                    }
                    matrix[i, j] = inputString[indexPositionString];
                    indexPositionString++;
                }
            }
            printMatrix(matrix);
        }
    }
}
