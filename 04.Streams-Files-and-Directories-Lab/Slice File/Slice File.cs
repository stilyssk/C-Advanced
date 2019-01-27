using System;
using System.IO;

namespace Slice_File
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sliceMe = new StreamReader(@"sliceMe.txt");
            long filesize = sliceMe.BaseStream.Length;

            int bufferSize = 4096;
            char[] buffer  = new char[bufferSize];
            int test;
            int count = 1;
            while (true)
            {
                test = sliceMe.Read(buffer, 0, bufferSize);
                if (test==0)
                {
                    break;
                }
                StreamWriter streamFile = new StreamWriter($"Part-{count}.txt",true);
                streamFile.Write(buffer);
                streamFile.Close();
                count++;
                Console.WriteLine(string.Join("", buffer));
                Console.WriteLine();
                Console.WriteLine(test);
                if (count>4)
                {
                    count = 1;
                }
              
             
            

          


            }
            sliceMe.Close();
            
        }
    }
}
