using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = PrintMessage;

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(print);
        }

        static void PrintMessage(string inputString)
        {
            Console.WriteLine($"Sir {inputString}");
        }
    }
}
