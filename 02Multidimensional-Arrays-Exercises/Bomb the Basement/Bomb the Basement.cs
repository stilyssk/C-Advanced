using System;
using System.Linq;

namespace Bomb_the_Basement
{
    class Program
    {
        static int[,] DuplicateRowOfMatrix(int[,] tempMatrix)
        {
            int[,] copyOfTempMatrix = new int[tempMatrix.GetLength(0),tempMatrix.GetLength(1)];
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    copyOfTempMatrix[i, j] = tempMatrix[i, j];
                }
            }
            int indexRow = 0;
            for (int i = 1; i < tempMatrix.GetLength(0); i++)
            {
                indexRow++;

                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    
                    tempMatrix[i, j] = copyOfTempMatrix[indexRow, j];

                }
                if (tempMatrix.GetLength(0) > (i + 1))
                {
                    i++;
                    for (int j = 0; j < tempMatrix.GetLength(1); j++)
                    {

                        tempMatrix[i, j] = copyOfTempMatrix[indexRow, j];

                    }
                }
            }
            return tempMatrix;
        }
        static int[,] transformMatrix (int[,] tempMatrix,int coordRow, int coordCol)
        {
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j <tempMatrix.GetLength(1); j++)
                {
                    if (tempMatrix.GetLength(0)> i + coordRow)
                    {
                        tempMatrix[i, j] = tempMatrix[i + coordRow, j];
                    }
                    else
                    {
                        tempMatrix[i, j] = 0;
                    }
                }
            }
            return tempMatrix;
        }
        static void printMatrix(int[,] tempMatrix)
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
        static bool insideInRadious (int tempCenterRow,int tempCenterCol, int tempRadius, int tempRow, int tempCol)
        {
            int rowLeght = tempRow - tempCenterRow;
            int colLeght = tempCol - tempCenterCol;
            bool result;
            if (Math.Pow(rowLeght, 2) + Math.Pow(colLeght, 2) <= Math.Pow(tempRadius, 2))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        static int[,] CalculateBumbRadius(int[,] tempMatrix, int tempRow,int tempColumn,int tempRadius)
        {
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    if (insideInRadious(tempRow, tempColumn, tempRadius,i,j))
                    {
                        tempMatrix[i, j] = 1;
                    }
                }
            }
            return tempMatrix;
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
            int[] boombCoordinate = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int boombRow = boombCoordinate[0];
            int boombCol = boombCoordinate[1];
            int boombRadius = boombCoordinate[2];
            //printMatrix(matrix);
            matrix = CalculateBumbRadius(matrix, boombRow, boombCol, boombRadius);
            //Console.WriteLine();
            //Console.WriteLine();
            //printMatrix(matrix);
            //Console.WriteLine();
            //Console.WriteLine();
            matrix = transformMatrix(matrix, boombRow, boombCol);
            //printMatrix(matrix);
            //Console.WriteLine();
            //Console.WriteLine();
            matrix = DuplicateRowOfMatrix(matrix);
            printMatrix(matrix);
            
        }
    }
}
