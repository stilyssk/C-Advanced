using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@".\Resources\01. Odd Lines\Input.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            using (StreamReader sr = new StreamReader(@".\Resources\01. Odd Lines\Input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"Output.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();
                        line = sr.ReadLine();
                        sw.WriteLine(line);

                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
