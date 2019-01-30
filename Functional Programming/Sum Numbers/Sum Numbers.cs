using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputLine = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var outputSum = inputLine.Sum();
            var outputCount = inputLine.Count();
            Console.WriteLine(outputCount);
            Console.WriteLine(outputSum);
        }
    }
}
