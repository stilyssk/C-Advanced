using System;
using System.Collections.Generic;
using System.Linq;

namespace Jagged_Array_Modification
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
            while (true)
            {
                List<string> commands = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = commands[0];
                if (command=="END")
                {
                    break;
                }
                commands.RemoveAt(0);
                int[] dataMatrix = commands
                    .Select(int.Parse)
                    .ToArray();
                switch (command)
                {
                    case "Add":
                        //Console.WriteLine(string.Join(" ",dataMatrix));
                        if (dataMatrix[0]<dimentions&&dataMatrix[1]<dimentions&&
                            dataMatrix[0] >= 0 && dataMatrix[1] >= 0)
                        {
                            matrix[dataMatrix[0], dataMatrix[1]] += dataMatrix[2];
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        //Console.WriteLine(string.Join(" ", dataMatrix));

                        if (dataMatrix[0] < dimentions && dataMatrix[1] < dimentions &&
                            dataMatrix[0] >= 0 && dataMatrix[1] >= 0)
                        {
                            matrix[dataMatrix[0], dataMatrix[1]] -= dataMatrix[2];
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                        

                    default:
                        break;
                }

            }
            for (int i = 0; i < dimentions; i++)
            {
                for (int j = 0; j < dimentions; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
