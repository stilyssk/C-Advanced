using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@".\Input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"Output.txt"))
                {
                    int countRow= 0;
                    while (!sr.EndOfStream)
                    {
                        countRow++;
                        String line = sr.ReadLine();
                        sw.WriteLine($"{countRow}.\t{line}");

                        Console.WriteLine($"{countRow}.\t{line}");
                    }
                }
            }
        }
    }
}
