using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string,int>> storeClothes = new Dictionary<string, Dictionary<string, int>>();
            
            for (int i = 0; i < repeat; i++)
            {
                string[] inputString = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string collor = inputString[0];
                List<string> clothes = inputString[1]
                    .Split(new string[] { ","}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!storeClothes.ContainsKey(collor))
                {
                    Dictionary<string, int> tempClothesData = new Dictionary<string, int>();
                    foreach (var item in clothes)
                    {
                        if (!tempClothesData.ContainsKey(item))
                        {
                            tempClothesData.Add(item, 1);
                        }
                        else
                        {
                            tempClothesData[item]++;
                        }
                    }
                    storeClothes.Add(collor, tempClothesData);
                }
                else
                {
                    Dictionary<string, int> tempClothesData = new Dictionary<string, int>();
                    tempClothesData = storeClothes[collor];
                    foreach (var item in clothes)
                    {
                        if (!tempClothesData.ContainsKey(item))
                        {
                            tempClothesData.Add(item, 1);
                        }
                        else
                        {
                            tempClothesData[item]++;
                        }
                    }
                    storeClothes[collor] = tempClothesData;
                }

            }
            List<string> searchClothes = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string searchCollor = searchClothes[0];
            string searchDress = searchClothes[1];

            foreach (var collorVar in storeClothes)
            {
                Console.WriteLine($"{collorVar.Key} clothes:");
                foreach (var clotesVar in collorVar.Value)
                {
                    string tempString = "";
                    if (collorVar.Key==searchCollor&&searchDress==clotesVar.Key)
                    {
                        tempString = " (found!)";
                    }
                    Console.WriteLine($"* {clotesVar.Key} - {clotesVar.Value}{tempString}");

                }
            }

        }
    }
}
