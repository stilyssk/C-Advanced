using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"../../../../");
            var result = di.EnumerateFiles("*", SearchOption.TopDirectoryOnly);
            List<FileInfo> test2 = result.OrderBy(x => x.Extension).ToList();
            string oldExtension = "";
            foreach (var item in test2)
            {
                if (item.Extension!=oldExtension )
                {
                    Console.WriteLine(item.Extension);
                    oldExtension = item.Extension;
                }
                Console.WriteLine($"--{item.Name} - {item.Length / 1024}kb");

            }

        }
    }
}
