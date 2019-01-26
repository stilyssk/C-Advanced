using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] repeatNandM = Console.ReadLine().
                Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> firstHS = new HashSet<int>();
            HashSet<int> secondHS = new HashSet<int>();
            HashSet<int> resultHS = new HashSet<int>();

            for (int i = 0; i < repeatNandM[0]; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                firstHS.Add(readNumber);
            }
            for (int i = 0; i < repeatNandM[1]; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                secondHS.Add(readNumber);
            }
            foreach (var firstHSNumber in firstHS)
            {
                foreach (var secondHSNumber in secondHS)
                {
                    if (firstHSNumber==secondHSNumber)
                    {
                        resultHS.Add(secondHSNumber);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",resultHS));

        }
    }
}
