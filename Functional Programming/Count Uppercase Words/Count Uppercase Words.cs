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
            //Regex regexString = new Regex(@"[A-Z]\w+");
            Func<string, bool> checkFirstLetter = CheckFirstUpperLetter;

            List<string> outputResult = inputLine.Where(checkFirstLetter).ToList();
            foreach (var item in outputResult)
            {
                Console.WriteLine(item);
            }
         }
        static bool CheckFirstUpperLetter(string inputString)
        {
            bool result = false;
            for (char i = 'A'; i <='Z'; i++)
            {
                if (inputString[0]==i)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
