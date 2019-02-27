using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelFunctions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            string[][] storeMatrix = new string[repeat-1][];
            List<string> header = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            for (int i = 0; i < repeat-1; i++)
            {
                var readDataLine = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                storeMatrix[i] = readDataLine;
            }
            string[] inputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            string command = inputCommand[0];
            switch (command)
            {
                case "hide":
                    string hideHeader = inputCommand[1];
                    var indexHide = header.FindIndex(x => x == hideHeader);
                    for (int i = 0; i < storeMatrix.GetLength(0); i++)
                    {
                        var tempList = storeMatrix[i].ToList();
                        tempList.RemoveAt(indexHide);
                        storeMatrix[i] = tempList.ToArray();
                    }
                    header.RemoveAt(indexHide);
                    break;
                case "sort":
                    string sortHeader = inputCommand[1];
                    var index = header.FindIndex(x => x == sortHeader);
                    storeMatrix=storeMatrix.OrderBy(x => x[0][index]).ToArray();
                    break;
                case "filter":
                    string filterHeader = inputCommand[1];
                    var indexFilter = header.FindIndex(x => x == filterHeader);

                    string compareData = inputCommand[2];
                    storeMatrix = storeMatrix.Where(x => x[indexFilter] == compareData).ToArray();
                    break;
                default:
                    break;
            }
            Console.WriteLine(string.Join(" | ", header));

            foreach (var item in storeMatrix)
            {
                Console.WriteLine(string.Join(" | ", item));
            }
        }
    }
}
