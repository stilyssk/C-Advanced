using System;
using System.Collections.Generic;
using System.Linq;

namespace Swap_Method_Integers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            //List<Box<string>> listClassBox = new List<Box<string>>();
            swapClass<int> swapClassList = new swapClass<int>();
            for (int i = 0; i < repeat; i++)
            {
                int inputData = int.Parse(Console.ReadLine());
                var newBoxInt = new Box<int>(inputData);
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
