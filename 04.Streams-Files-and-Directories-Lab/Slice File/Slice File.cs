using System;
using System.IO;

namespace Slice_File
{
    class Program
    {
        static void writeToFile (string nameOfFile,char[] tempBuffer)
        {
            StreamWriter streamFile = new StreamWriter(nameOfFile, true);
            streamFile.Write(tempBuffer);

            streamFile.Close();

        }
        static void Main(string[] args)
        {
            StreamReader sliceMe = new StreamReader(@"sliceMe.txt");
            long filesize = sliceMe.BaseStream.Length;
            int partSize = (int)filesize / 4;
            int counterParts = 0;            
            int currentPartSize;
            int count = 1;
            while (true)
            {
                int bufferSize = 4096;
                char[] buffer = new char[bufferSize];


                if ((partSize-counterParts)<bufferSize)
                {
                    bufferSize = partSize - counterParts;
                    currentPartSize = sliceMe.Read(buffer, 0, bufferSize);

                    if (currentPartSize == 0)
                    {
                        break;
                    }
                    counterParts += currentPartSize;
                    string nameOfFile = $"Part-{count}.txt";
                    writeToFile(nameOfFile, buffer);
                    count++;
                    counterParts = 0;
                }
                else
                {
                    currentPartSize = sliceMe.Read(buffer, 0, bufferSize);
                    counterParts += currentPartSize;
                    Console.WriteLine(currentPartSize);
                    if (currentPartSize == 0||currentPartSize==1)
                    {
                        break;
                    }
                    string nameOfFile = $"Part-{count}.txt";
                    writeToFile(nameOfFile, buffer);

                }
            }
            sliceMe.Close();
            
        }
    }
}
