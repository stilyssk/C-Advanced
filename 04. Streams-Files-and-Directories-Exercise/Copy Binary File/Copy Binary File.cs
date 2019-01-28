using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream openFile = File.Open("../../../PredpechatnaMulnieotvodna-a4HV hp5si.pdf", FileMode.Open))
            {
                using (FileStream saveFile = File.Create("../../../test.pdf"))
                {

                    int bufferSize = 4096;
                    byte[] readBuffer = new byte[bufferSize];
                    int countReadByte = 0;
                    while (true)
                    {
                        countReadByte = openFile.Read(readBuffer, 0, bufferSize);
                        saveFile.Write(readBuffer, 0, countReadByte);
                        if (countReadByte < bufferSize)
                        {
                            break;
                        }
                    }
                }
            }

        }
    }
}
