using System;
using System.Linq;

namespace TronRacers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int dimmentionMatrix = int.Parse(Console.ReadLine());
            char[][] playerField = new char[dimmentionMatrix][];
            for (int i = 0; i < playerField.Length; i++)
            {
                var newLineInMatrix = Console.ReadLine().ToCharArray();
                playerField[i] = newLineInMatrix;
            }

            int fCoordinateI = 0;
            int fCoordinateJ = 0;
            int sCoordinateI = 0;
            int sCoordinateJ = 0;
            for (int i = 0; i < playerField.Length; i++)
            {
                for (int j = 0; j < playerField[i].Length; j++)
                {
                    if (playerField[i][j]=='s')
                    {
                        sCoordinateI = i;
                        sCoordinateJ = j;
                    }
                    else if (playerField[i][j] == 'f')
                    {
                        fCoordinateI = i;
                        fCoordinateJ = j;
                    }
                }
            }
            while (true)
            {
                var inputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string firstPlayerCommand = inputCommand[0];
                string secondPlayerCommand = inputCommand[1];
                var firstPlayerCoordinate = calculateCoordinate(fCoordinateI, fCoordinateJ, dimmentionMatrix, firstPlayerCommand);
                fCoordinateI = firstPlayerCoordinate[0];
                fCoordinateJ = firstPlayerCoordinate[1];

                var secondPlayerCoordinate = calculateCoordinate(sCoordinateI, sCoordinateJ, dimmentionMatrix, secondPlayerCommand);
                sCoordinateI = secondPlayerCoordinate[0];
                sCoordinateJ = secondPlayerCoordinate[1];

                if (playerField[fCoordinateI][fCoordinateJ]=='s')
                {
                    playerField[fCoordinateI][fCoordinateJ] = 'x';

                    break;
                }

                if (playerField[sCoordinateI][sCoordinateJ] == 'f')
                {
                    playerField[sCoordinateI][sCoordinateJ] = 'x';

                    break;
                }

                if (fCoordinateI==sCoordinateI&&fCoordinateJ==sCoordinateJ)
                {
                    playerField[fCoordinateI][fCoordinateJ] = 'x';
                    break;
                }

                playerField[fCoordinateI][fCoordinateJ] = 'f';
                playerField[sCoordinateI][sCoordinateJ] = 's';
                //for (int i = 0; i < playerField.Length; i++)
                //{
                //    for (int j = 0; j < playerField[i].Length; j++)
                //    {
                //        Console.Write(playerField[i][j]);
                //    }
                //    Console.WriteLine();
                //}
            }
            for (int i = 0; i < playerField.Length; i++)
            {
                for (int j = 0; j < playerField[i].Length; j++)
                {
                    Console.Write(playerField[i][j]);
                }
                Console.WriteLine();
            }
        }


        public static  int[] calculateCoordinate(int iCoordiante , int jCoordinate, int dimmention,string moveCommand)
        {
            int realDimention = dimmention - 1;
            switch (moveCommand)
            {
                case "up":
                    iCoordiante--;
                    if (iCoordiante < 0)
                    {
                        iCoordiante = realDimention;
                    }
                    break;
                case "down":
                    iCoordiante++;
                    if (iCoordiante > realDimention)
                    {
                        iCoordiante = 0;
                    }
                    break;
                case "left":
                    jCoordinate--;
                    if (jCoordinate < 0)
                    {
                        jCoordinate = realDimention;
                    }
                    break;
                case "right":
                    jCoordinate++;
                    if (jCoordinate > realDimention)
                    {
                        jCoordinate = 0;
                    }
                    break;
                default:
                    break;
            }
            int[] result = new int[2];
            result[0] = iCoordiante;
            result[1] = jCoordinate;

            return result;
        }

    }
}
