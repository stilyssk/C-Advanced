using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> chemicalHS = new HashSet<string>();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                string[] inputElements = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var element in inputElements)
                {
                    chemicalHS.Add(element);
                }
            }
            chemicalHS = chemicalHS.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ", chemicalHS));
        }
    }
}
