using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix_shuffling
{
    class Program
    {
        static bool ChekCoord (int checkedCoord,  int coordMax)
        {
            bool result = false;
            if (checkedCoord>=0&&checkedCoord<coordMax)
            {
                result = true;
            }
            return result;
        }
        static void printMatrix (string[,] tempMatrix)
        {
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    Console.Write($"{tempMatrix[i,j]} ");
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
            string[,] matrix = new string[row, column];
            for (int i = 0; i < row; i++)
            {
                string[] readRow = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)                 
                    .ToArray();
                for (int j = 0; j < column; j++)
                {

                    matrix[i, j] = readRow[j];
                }
                
            }
            while (true)
            {
                List<string> inputCommand = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                string command = inputCommand[0];
                inputCommand.RemoveAt(0);
                int[] inputDataArray = inputCommand
                    .Select(int.Parse)
                    .ToArray();
                if (command == "END")
                {
                    break;

                }
                if (command == "swap")
                {
                    if (inputDataArray.Length == 4)
                    {
                        int firstRow = inputDataArray[0];
                        int secondRow = inputDataArray[2];
                        int firstCol = inputDataArray[1];
                        int secondCol = inputDataArray[3];
                        if (ChekCoord(firstRow, row) &&
                            ChekCoord(firstCol, column) &&
                            ChekCoord(secondRow, row) &&
                            ChekCoord(secondCol, column)
                            )
                        {
                            string tempStoreData = matrix[firstRow, firstCol];
                            matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                            matrix[secondRow, secondCol] = tempStoreData;
                            printMatrix(matrix);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");

                }
            }

        }
    }
}
