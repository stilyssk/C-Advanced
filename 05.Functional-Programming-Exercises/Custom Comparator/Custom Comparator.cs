using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputIntNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> evenListint = new List<int>();
            List<int> oddListint = new List<int>();

            Func<int, bool> funcEven = x =>
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                return false;
            };
            Array.Sort(inputIntNumbers);

            Func<int, bool> funcIsOdd = x => x % 2 == 0;
            for (int i = 0; i < inputIntNumbers.Length; i++)
            {
                if (funcEven(inputIntNumbers[i]))
                {
                    evenListint.Add(inputIntNumbers[i]);
                }
                else
                {
                    oddListint.Add(inputIntNumbers[i]);
                }
            }
            string printResult = string.Join(' ', evenListint);
            printResult += ' ';
            printResult += string.Join(' ', oddListint);
            Console.WriteLine(printResult);

        }
    }
}
