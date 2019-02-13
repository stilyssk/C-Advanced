using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_Strings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            //List<Box<string>> listClassBox = new List<Box<string>>();
            swapClass<string> swapClassList = new swapClass<string>();
            for (int i = 0; i < repeat; i++)
            {
                string inputData = Console.ReadLine();
                var newBoxInt = new Box<string>(inputData);
                swapClassList.Add(newBoxInt);

            }
            //swapClassList.Print();
            List<int> inputIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int firstIndex = inputIndexes[0];
            int secondIndex = inputIndexes[1];
            swapClassList.Swap(firstIndex, secondIndex);
            swapClassList.Print();

        }

    }
}
