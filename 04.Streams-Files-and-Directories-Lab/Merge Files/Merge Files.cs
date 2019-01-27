using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileOne = new StreamReader(@"FileOne.txt");
            StreamReader fileTwo = new StreamReader(@"FileTwo.txt");
            StreamWriter fileOut = new StreamWriter(@"Output.txt");
            string readLineFromFile = "";
            while (!fileOne.EndOfStream&&!fileTwo.EndOfStream)
            {
                readLineFromFile = fileOne.ReadLine();
                fileOut.WriteLine(readLineFromFile);
                readLineFromFile = fileTwo.ReadLine();
                fileOut.WriteLine(readLineFromFile);

            }
            fileOne.Close();
            fileTwo.Close();
            fileOut.Close();
        }
    }
}
