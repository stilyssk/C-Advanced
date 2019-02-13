using System;

namespace Generic_Box_of_Integer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                int inputData = int.Parse(Console.ReadLine());
                var boxGeneric = new Box<int>(inputData);
                Console.WriteLine(boxGeneric.ToString());
            }
        }
    }
}
