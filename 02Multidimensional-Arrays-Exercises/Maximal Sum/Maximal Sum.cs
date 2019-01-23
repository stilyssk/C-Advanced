using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static int makeSquareMatrixSum (int[,] tempMatrix,int positionRow, int positionColumn)
        {
            int[,] tempSearchMatrix = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += tempMatrix[positionRow + i, positionColumn + j];
                }
            }

            return sum;
        }
        static int[,] makeSquareMatrix(int[,] tempMatrix, int positionRow, int positionColumn)
        {
            int[,] tempSearchMatrix = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tempSearchMatrix[i,j] = tempMatrix[positionRow + i, positionColumn + j];
                }
            }

            return tempSearchMatrix;
        }
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                                        .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
            int row = dimentions[0];
            int column = dimentions[1];
            int[,] matrix = new int[row, column];
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
            int[,] searchMatrix = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < row - 2; i++)
            {
                
                for (int j = 0; j < column - 2; j++)
                {
                    int tempSum = makeSquareMatrixSum(matrix,i,j);
                    if (sum<tempSum)
                    {
                        sum = tempSum;
                        searchMatrix= makeSquareMatrix(matrix, i, j);
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{searchMatrix[i,j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
