using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexstring = new Regex("^[0-9]\\w+");
            HashSet<string> vipGest = new HashSet<string>();
            HashSet<string> otherGest = new HashSet<string>();
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString== "PARTY")
                {
                    break;
                }
                Match vipGestMath = regexstring.Match(inputString);
                if (vipGestMath.Success)
                {
                    vipGest.Add(inputString);
                }
                else
                {
                    otherGest.Add(inputString);
                }
            }
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "END")
                {
                    break;
                }
                Match vipGestMath = regexstring.Match(inputString);
                if (vipGestMath.Success)
                {
                    if (vipGest.Contains(inputString))
                    {
                        vipGest.Remove(inputString);

                    }
                }
                else
                {
                    if (otherGest.Contains(inputString))
                    {
                        otherGest.Remove(inputString);

                    }
                }
            }
            Console.WriteLine(vipGest.Count+otherGest.Count);
            foreach (var nameVipGest in vipGest)
            {
                Console.WriteLine(nameVipGest);
            }
            foreach (var nameOhterGest in otherGest)
            {
                Console.WriteLine(nameOhterGest);
            }
        }
    }
}
