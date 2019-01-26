using System;
using System.Collections.Generic;
using System.Linq;
namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Dictionary<char, int> leterCountStoreDict = new Dictionary<char, int>();

            foreach (var charElement in inputString)
            {
                if (!leterCountStoreDict.ContainsKey(charElement))
                {
                    leterCountStoreDict.Add(charElement, 1);
                }
                else
                {
                    leterCountStoreDict[charElement]++;
                }
            }
            leterCountStoreDict = leterCountStoreDict
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var leterCount in leterCountStoreDict)
            {
                Console.WriteLine($"{leterCount.Key}: {leterCount.Value} time/s");
            }

        }
    }
}
