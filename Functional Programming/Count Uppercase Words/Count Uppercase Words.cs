using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Count_Uppercase_Words
{
    class Program
    {
         
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Regex regexString = new Regex(@"[A-Z]\w+");
        
            List<string> outputResult = inputLine.Where(x=>regexString.Match(x).Success).ToList();
            foreach (var item in outputResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
