using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimentions, dimentions];
            for (int i = 0; i < dimentions; i++)
            {
                int[] readRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < dimentions; j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int indexReverce = matrix.GetLength(0) - i-1;
                sumLeft += matrix[i, i];
                sumRight += matrix[i, indexReverce];
            }
            int result = Math.Abs(sumLeft-sumRight);

            Console.WriteLine(result);
        }
    }
}
