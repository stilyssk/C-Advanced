using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"../../../../Text.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"Output.txt"))
                {
                    int countRow = 0;
                    while (!sr.EndOfStream)
                    {
                        countRow++;
                        String line = sr.ReadLine();
                        Regex regexPunctuation = new Regex(@"[?\-',.\!]");
                        Regex regexChar = new Regex(@"\w");
                        int countChar = 0;
                        foreach (var item in regexChar.Matches(line))
                        {
                            countChar++;
                        }
                        int countPunctuation = 0;
                        foreach (var item in regexPunctuation.Matches(line))
                        {
                            countPunctuation++;
                        }
                        sw.WriteLine($"Line {countRow}: {line}{countChar}/{countPunctuation}");

                        Console.WriteLine($"Line {countRow}: {line}{countChar}/{countPunctuation}");
                    }
                }
            }
        }
    }
}
