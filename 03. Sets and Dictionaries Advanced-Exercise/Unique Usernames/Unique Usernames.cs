using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernamesHS = new HashSet<string>();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                string inputName = Console.ReadLine();
                usernamesHS.Add(inputName);

            }
            foreach (var name in usernamesHS)
            {
                Console.WriteLine(name);
            }
        }
    }
}
