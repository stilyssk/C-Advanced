using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                            .Split(new string[] { ", ", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int row = dimentions[0];
            int column = dimentions[1];
            int[,] matrix = new int[row,column];
            for (int i = 0; i < row; i++)
            {
                int[] readRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < column; j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            for (int i = 0; i < column; i++)
            {
                int sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
