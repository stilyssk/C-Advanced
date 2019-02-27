using System;

namespace Sneaking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int countRow = int.Parse(Console.ReadLine());
            char[][] figthPlant = new char[countRow][];
            
            for (int i = 0; i < countRow; i++)
            {
                var inputRow = Console.ReadLine()
                    .ToCharArray();
                figthPlant[i] = inputRow;
            }
            int samCoordinateI = 0;
            int samCoordinateJ = 0;
            int nicoladzeI = 0;
            int nicoladzeJ = 0;

            char[] moveCommand  = Console.ReadLine()
                    .ToCharArray();
            for (int i = 0; i < figthPlant.GetLength(0); i++)
            {
                for (int j = 0; j < figthPlant[i].Length; j++)
                {
                    if (figthPlant[i][j]=='S')
                    {
                        samCoordinateI = i;
                        samCoordinateJ = j;
                        figthPlant[i][j] = '.';
                    }
                    if (figthPlant[i][j] == 'N')
                    {
                        nicoladzeI = i;
                        nicoladzeJ = j;
                        figthPlant[i][j] = '.';
                    }
                }
            }
            for (int i = 0; i < moveCommand.Length; i++)
            {
                figthPlant = MovePatrul(figthPlant);
                PrintAll(figthPlant);
                switch (moveCommand[i])
                {
                    case 'U':
                        if (samCoordinateI > 0)
                        {
                            samCoordinateI--;
                        }
                        break;
                    case 'D':
                        if (samCoordinateI < countRow - 1)
                        {
                            samCoordinateI++;
                        }
                        break;
                    case 'L':
                        if (samCoordinateJ > 0)
                        {
                            samCoordinateJ--;
                        }
                        break;
                    case 'R':
                        if (samCoordinateJ < figthPlant[0].Length - 1)
                        {
                            samCoordinateJ++;
                        }
                        break;
                    case 'W':
                        break;
                    default:
                        break;
                }
                var current = figthPlant[samCoordinateI][ samCoordinateJ];
                if (current =='d'||current=='b')
                {
                    figthPlant[samCoordinateI][samCoordinateJ] = '.';
                }

                if (checkKill(figthPlant,samCoordinateI,samCoordinateJ))
                {
                    figthPlant[nicoladzeI][nicoladzeJ] = 'N';

                    Console.WriteLine($"Sam died at {samCoordinateI}, {samCoordinateJ}");
                    figthPlant[samCoordinateI][samCoordinateJ] = 'X';
                    break;

                }
                if (samCoordinateI ==nicoladzeI )
                {
                    Console.WriteLine("Nikoladze killed!");
                    figthPlant[samCoordinateI][samCoordinateJ] = 'S';
                    figthPlant[nicoladzeI][nicoladzeJ] = 'X';
                    break;
                }
            }
            PrintAll(figthPlant);
        }

        static char[][] MovePatrul(char[][] tempfigthPlant)
        {
            var maxI = tempfigthPlant.GetLength(0);
            var maxJ = tempfigthPlant[0].Length;
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    var current = tempfigthPlant[i][j];
                    if (current == 'b')
                    {
                        if (j<maxJ-1)
                        {
                            tempfigthPlant[i][j] = '.';
                            tempfigthPlant[i][j + 1] = 'b';
                            if (j+1== maxJ-1)
                            {
                                tempfigthPlant[i][j + 1] = 'd';
                                tempfigthPlant[i][j] = '.';

                            }
                            break;
                        }

                    }
                    else if (current == 'd')
                    {
                        if (j >0)
                        {
                            tempfigthPlant[i][j] = '.';
                            tempfigthPlant[i][j - 1] = 'd';
                            if (j-1==0)
                            {
                                tempfigthPlant[i][j - 1] = 'b';
                                tempfigthPlant[i][j] = '.';

                            }
                            break;
                        }

                    }
                }
            }
            
            return tempfigthPlant;
        }


        static bool checkKill(char[][] tempfigthPlant,int samI,int samJ)
        {
 


            for (int x = 0; x < tempfigthPlant[0].Length; x++)
            {
                if (x < samJ && tempfigthPlant[samI][x] == 'b')
                {
                    return true;
                }
                else if (x > samJ && tempfigthPlant[samI][x] == 'd')
                {
                    return true;
                }

            }
            return false;
        }

        static void PrintAll (char[][] tempFightPlant)
        {
            for (int i = 0; i < tempFightPlant.GetLength(0); i++)
            {
                for (int j = 0; j < tempFightPlant[0].Length; j++)
                {
                    Console.Write(tempFightPlant[i][j]);
                }
                Console.WriteLine();
            }
        } 
    }
}
