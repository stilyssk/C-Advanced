using System;

namespace Count_Method_Doubles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            swapClass<double> swapClassList = new swapClass<double>();
            for (int i = 0; i < repeat; i++)
            {
                double inputData = double.Parse(Console.ReadLine());
                var newBoxInt = new Box<double>(inputData);
                swapClassList.Add(newBoxInt);

            }

            double compareString = double.Parse(Console.ReadLine());
            int resultFromComapre = swapClassList.Compare(compareString);
            Console.WriteLine(resultFromComapre);
        }
    }
}
