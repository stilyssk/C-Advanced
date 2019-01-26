using System;
using System.Collections.Generic;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static bool CheckMatrixLE1(char[,] tempMatrix)
        {
            int max = 0;
            bool matrixIsFinish = false;
            foreach (char item in tempMatrix)
            {
                string test = item.ToString();
                if (test!="K")
                {
                    int itemInt = int.Parse(test);
                    if (max < itemInt)
                    {
                        max = itemInt;
                    } 
                }
            }
            if (max<=1)
            {
                matrixIsFinish = true;
                
            }
            return matrixIsFinish;
        }
        static bool CheckMatrixLE1Int(int[,] tempMatrix)
        {
            int max = 0;
            bool matrixIsFinish = false;
            foreach (int item in tempMatrix)
            {
                if (item != 1)
                {
                    int itemInt = item;
                    if (max < itemInt)
                    {
                        max = itemInt;
                    }
                }
            }
            if (max <= 1)
            {
                matrixIsFinish = true;

            }
            return matrixIsFinish;
        }
        static char[,] removeMax (char[,] tempMatrix)
        {
            int max = 0;
            foreach (var item in tempMatrix)
            {
                string test = item.ToString();
                if (test != "K")
                    if (test != "K")
                {
                    if (max < int.Parse(item.ToString()))
                    {
                        max = int.Parse(item.ToString());
                    } 
                }
            }
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    if (tempMatrix[i,j]==max.ToString()[0])
                    {
                        tempMatrix[i, j] = '0';
                        return tempMatrix;
                    }
                }
            }
            return tempMatrix;
        }
        static int[,] removeMaxInt(int[,] tempMatrix)
        {
            int max = 0;
            foreach (var item in tempMatrix)
            {
                if (item != 1)
                    if (item != 1)
                    {
                        if (max < item)
                        {
                            max = item;
                        }
                    }
            }
            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    if (tempMatrix[i, j] == max)
                    {
                        tempMatrix[i, j] = 0;
                        return tempMatrix;
                    }
                }
            }
            return tempMatrix;
        }
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
        static void printMatrixInt(int[,] tempMatrix)
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
        static int CountOfKinght (char[,] tempMatrix, int currentRow, int currentCol)
        {
            int dimRow = tempMatrix.GetLength(0);
            int dimCol = tempMatrix.GetLength(1);
            List<int[]> combination = new List<int[]>
            {
                new int[] {1,2},
                new int[] {-1,2},
                new int[] {1,-2},
                new int[] {-1,-2},
                new int[] {2,1},
                new int[] {-2,1},
                new int[] {2,-1},
                new int[] {-2,-1}
            };
            int result=0;
            foreach (int[] position in combination)
            {
                int ofsetRow = position[0];
                int ofsetCol = position[1];
                int positionRow = currentRow + ofsetRow;
                int positionCol = currentCol + ofsetCol;

                if (positionRow<dimRow&&positionRow>=0&&
                    positionCol < dimCol && positionCol >= 0&&
                    tempMatrix[currentRow, currentCol] !='0')
                {
                    if (tempMatrix[positionRow, positionCol] != '0')
                    {
                        result++;
                    } 
                }
            }
            return result;
        }

        static int CountOfKinghtInt(int[,] tempMatrix, int currentRow, int currentCol)
        {
            int dimRow = tempMatrix.GetLength(0);
            int dimCol = tempMatrix.GetLength(1);
            List<int[]> combination = new List<int[]>
            {
                new int[] {1,2},
                new int[] {-1,2},
                new int[] {1,-2},
                new int[] {-1,-2},
                new int[] {2,1},
                new int[] {-2,1},
                new int[] {2,-1},
                new int[] {-2,-1}
            };
            int result = 0;
            foreach (int[] position in combination)
            {
                int ofsetRow = position[0];
                int ofsetCol = position[1];
                int positionRow = currentRow + ofsetRow;
                int positionCol = currentCol + ofsetCol;

                if (positionRow < dimRow && positionRow >= 0 &&
                    positionCol < dimCol && positionCol >= 0 &&
                    tempMatrix[currentRow, currentCol] != 0)
                {
                    if (tempMatrix[positionRow, positionCol] != 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {

            int dimentions = int.Parse(Console.ReadLine());

            char[,] matrix = new char[dimentions, dimentions];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] readRow = Console.ReadLine().ToArray();
                    
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = readRow[j];

                }

            }
            int[,] copyMatrix = new int[dimentions, dimentions];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int tempData = 0;
                    if (matrix[i, j]=='K')
                    {
                        tempData = 1;
                    }
                    else
                    {
                        tempData = 0;
                    }
                    copyMatrix[i, j] = tempData;
                }
            }
            printMatrixInt(copyMatrix);
            //printMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int CountCollision = CountOfKinght(matrix, i, j);
                    if (CountCollision!=0)
                    {
                        matrix[i, j] = char.Parse(CountCollision.ToString());
                    }
                }
            }
            //Console.WriteLine();
            //Console.WriteLine();
            //printMatrix(matrix);
            //           matrix[2, 2] = '0';
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        int CountCollision = CountOfKinght(matrix, i, j);
            //        if (CountCollision != 0)
            //        {
            //            matrix[i, j] = char.Parse(CountCollision.ToString());
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            ////printMatrix(matrix);
            //matrix = removeMax(matrix);
            //printMatrix(matrix);




            //int countRemovet = 0;
            //while (!CheckMatrixLE1(matrix))
            //{
            //    //Console.WriteLine();
            //    //Console.WriteLine();
            //    matrix = removeMax(matrix);
            //    //printMatrix(matrix);
            //    countRemovet++;
            //}
            //Console.WriteLine(countRemovet);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int CountCollision = CountOfKinghtInt(copyMatrix, i, j);
                    if (CountCollision != 0)
                    {
                        copyMatrix[i, j] = CountCollision;
                    }
                }
            }
            printMatrixInt(copyMatrix);
            int countRemovet = 0;
            while (!CheckMatrixLE1Int(copyMatrix))
            {

                copyMatrix = removeMaxInt(copyMatrix);
                countRemovet++;
            }
            printMatrixInt(copyMatrix);
            Console.WriteLine(countRemovet);

        }
    }
}
