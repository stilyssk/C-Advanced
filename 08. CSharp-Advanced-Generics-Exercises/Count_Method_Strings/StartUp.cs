using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Method_Strings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            swapClass<string> swapClassList = new swapClass<string>();
            for (int i = 0; i < repeat; i++)
            {
                string inputData = Console.ReadLine();
                var newBoxInt = new Box<string>(inputData);
                swapClassList.Add(newBoxInt);

            }

            string compareString = Console.ReadLine();
            int resultFromComapre = swapClassList.Compare(compareString);
            Console.WriteLine(resultFromComapre);
        }
    }
}
