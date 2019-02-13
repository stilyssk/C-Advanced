using System;

namespace Generic_Box_of_String
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                string inputString = Console.ReadLine();
                var boxGeneric = new Box<string>(inputString);
                Console.WriteLine(boxGeneric.ToString());
            }
        }
    }
}
