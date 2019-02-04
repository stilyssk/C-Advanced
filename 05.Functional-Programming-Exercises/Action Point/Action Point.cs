using System;
using System.Linq;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = PrintMessage;

            Console.ReadLine()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(print);
        }

        static void PrintMessage(string inputString)
        {
            Console.WriteLine(inputString);
        }
    }
}
