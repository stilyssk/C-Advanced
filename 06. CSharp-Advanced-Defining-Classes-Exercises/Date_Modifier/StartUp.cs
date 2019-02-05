using System;

namespace Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier calculateDateDifference = new DateModifier(firstDate,secondDate);
            Console.WriteLine(calculateDateDifference.PrintResult());
        }
    }
}
