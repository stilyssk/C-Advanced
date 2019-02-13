using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            string firstString = inputString[0] + ' ' + inputString[1];
            string secondString = inputString[2];
            var firstLineTest = new TripleClass<string, string>(firstString,secondString);

            inputString = Console.ReadLine()
            .Split(new[] { ' ' })
            .ToList();
            firstString = inputString[0] ;
            int secondInt = int.Parse(inputString[1]);
            var secondLineTest = new TripleClass<string, int>(firstString, secondInt);

            inputString = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            int firstInt = int.Parse(inputString[0]);
            double secondDoube = double.Parse(inputString[1]);
            var thirdLineTest = new TripleClass<int, double>(firstInt, secondDoube);


            Console.WriteLine(firstLineTest.ToString());
            Console.WriteLine(secondLineTest.ToString());
            Console.WriteLine(thirdLineTest.ToString());

        }
    }
}
