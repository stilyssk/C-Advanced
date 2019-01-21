using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static int CalcSumMatrix (int[,] tempSearchMatrix)
        {
            int sum = 0;
            foreach (var item in tempSearchMatrix)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                                        .Split(new string[] { ", ", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
            int row = dimentions[0];
            int column = dimentions[1];
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                int[] readRow = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < column; j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            int[,] searchMatrix = new int[2, 2];
            int[,] maxMatrix = new int[2, 2];
            int sumMaxMatrix = 0;

            for (int i = 0; i < row-1; i++)
            {
                for (int j = 0; j < column-1; j++)
                {
                    searchMatrix[0, 0] = matrix[i, j];
                    searchMatrix[0, 1] = matrix[i, j+1];
                    searchMatrix[1, 0] = matrix[i+1, j];
                    searchMatrix[1, 1] = matrix[i+1, j+1];
                    int tempSumMaxMatrix = CalcSumMatrix(searchMatrix);
                    if (sumMaxMatrix<tempSumMaxMatrix)
                    {
                        sumMaxMatrix = tempSumMaxMatrix;
                        maxMatrix = (int[, ])searchMatrix.Clone() ;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{maxMatrix[i,0]} {maxMatrix[i, 1]}");
                
                Console.WriteLine();
            }
            Console.WriteLine(sumMaxMatrix);
        }
    }
}
