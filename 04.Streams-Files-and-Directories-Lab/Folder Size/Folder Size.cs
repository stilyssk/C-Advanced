using System;
using System.IO;
using System.Linq;

namespace Folder_Size
{
    class Program
    {
        private static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*", SearchOption.TopDirectoryOnly).Sum(x => x.Length);

            //di.EnumerateFiles("*", SearchOption.TopDirectoryOnly).Sum(fi => fi.Length);
        }
        static void Main(string[] args)
        {
            long folderSize = GetDirectorySize(@"../../../TestFolder");
            Double test= folderSize/(Double)(1024*1024);
            Console.WriteLine(test);
        }
    }
}
