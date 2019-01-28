using System;
using System.IO;
using System.Linq;

namespace _04._Streams_Files_and_Directories_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader(@"../../../Text.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"Output.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();


                        string[] stringArray = line
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                        Array.Reverse(stringArray);
                        line = string.Join(" ", stringArray);
                        char[] replaceSymbol = new char[] { '-', ',', '.', '!', '?' };
                        for (int i = 0; i < replaceSymbol.Length; i++)
                        {
                            line = line.Replace(replaceSymbol[i], '@');

                        }
                        sw.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
