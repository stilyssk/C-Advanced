using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());

            char[,] matrix = new char[dimentions, dimentions];
            for (int i = 0; i < dimentions; i++)
            {
                string readRow = Console.ReadLine();
                for (int j = 0; j < dimentions; j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            char compareChar = Console.ReadLine()[0];
            bool flagFindChar = false;
            int row = 0;
            int column = 0;
            for (int i = 0; i < dimentions; i++)
            {

                if (!flagFindChar)
                {
                    for (int j = 0; j < dimentions; j++)
                    {
                        if (compareChar == matrix[i, j])
                        {
                            row = i;
                            column = j;
                            flagFindChar = true;
                            break;
                        }
                    } 
                }
            }
            if (flagFindChar)
            {
                Console.WriteLine($"({row}, {column})");
            }
            else
            {
                Console.WriteLine($"{compareChar} does not occur in the matrix");
            }
        }
    }
}
