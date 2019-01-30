using System;
using System.Collections.Generic;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputLine = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            List<double> outputResult = inputLine.Select(x => x * 1.2).ToList();
            foreach (var item in outputResult)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
