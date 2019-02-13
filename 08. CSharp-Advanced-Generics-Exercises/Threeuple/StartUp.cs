using System;
using System.Collections.Generic;
using System.Linq;

namespace Threeuple
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
            string thirdString = inputString[3];
            var firstLineTest = new ThreeupleClass<string, string,string>(firstString, secondString, thirdString);

            inputString = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            firstString = inputString[0];
            int secondInt = int.Parse(inputString[1]);

     

            bool index3 = inputString[2]== "drunk"?true:false;
            var secondLineTest = new ThreeupleClass<string, int,bool>(firstString, secondInt, index3);

            inputString = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            firstString = inputString[0];
            double secondDoube = double.Parse(inputString[1]);
            thirdString = inputString[2];
            var thirdLineTest = new ThreeupleClass<string, double,string>(firstString, secondDoube,thirdString);


            Console.WriteLine(firstLineTest.ToString());
            Console.WriteLine(secondLineTest.ToString());
            Console.WriteLine(thirdLineTest.ToString());

        }
    }
}
