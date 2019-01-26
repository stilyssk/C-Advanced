using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            HashSet<string> namesCollection = new HashSet<string>();
            for (int i = 0; i < repeat; i++)
            {
                namesCollection.Add(Console.ReadLine());
            }
            foreach (var name in namesCollection)
            {
                Console.WriteLine(name);
            }
        }
    }
}
