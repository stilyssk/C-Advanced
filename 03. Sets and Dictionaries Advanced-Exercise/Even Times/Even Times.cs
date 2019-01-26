using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            HashSet<int> numbersHS = new HashSet<int>();
            HashSet<int> resultHS = new HashSet<int>();

            for (int i = 0; i < repeat; i++)
            {

                int number = int.Parse(Console.ReadLine());

                if (numbersHS.Contains(number))
                {
                    resultHS.Add(number);
                }
                numbersHS.Add(number);

            }
            Console.WriteLine(string.Join(" ",resultHS));
        }
    }
}
