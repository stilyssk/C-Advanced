using System;
using System.Linq;

namespace _2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                                        .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
            int row = dimentions[0];
            int column = dimentions[1];
            char[,] matrix = new char[row, column];
            for (int i = 0; i < row; i++)
            {
                char[] readRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < column; j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            char[,] searchMatrix = new char[2, 2];
            int count = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < column - 1; j++)
                {
                    if ((matrix[i, j]== matrix[i, j + 1])&&
                        (matrix[i, j] == matrix[i + 1, j])&&
                        (matrix[i, j] == matrix[i + 1, j + 1]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}
