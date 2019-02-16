
namespace Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var inputCommand = Console.ReadLine()
                .Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Lake listOfStones = new Lake(inputCommand);
            var printList = new List<int>();
            foreach (var item in listOfStones)
            {
                printList.Add(item);
            }

            Console.WriteLine(string.Join(", ",printList));

            //foreach (var item in listOfStones)
            //{
            //    Console.Write(item);
            //}
        }
    }
}
