using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputLine = Console.ReadLine()
                .Split(new string[] {", " },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var outputString = inputLine.Where(x=>x%2==0).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ",outputString));
            //foreach (var item in outputString)
            //{
                
            //}
        }
    }
}
