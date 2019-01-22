using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputSizeMatric = long.Parse(Console.ReadLine());
            long[][] matrix = new long[inputSizeMatric][];
            
            matrix[0] = new long[1] {1};

            for (int i = 1; i < inputSizeMatric; i++)
            {
                long[] tempMatrix = new long[i + 1];

                for (int j = 0; j <= i; j++)
                {
                    long firstValue = 0;
                    long secondValue = 0;
                    if (j-1>=0)
                    {
                        firstValue = matrix[i - 1][j - 1];
                    }
                    if (j<matrix[i-1].Length)
                    {
                        secondValue = matrix[i - 1][j];
                    }
                    tempMatrix[j] = firstValue + secondValue;
                }
                matrix[i] = tempMatrix;
            }
            for (int i = 0; i < inputSizeMatric; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
