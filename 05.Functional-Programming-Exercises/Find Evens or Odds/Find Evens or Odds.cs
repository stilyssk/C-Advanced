using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Predicate<List<int>> predicateFindOddNumber = FindOdd;
            Predicate<List<int>> predicateFindEvenNumber = FindEven;

            List<int> inputIntData =Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string inputCommand = Console.ReadLine();
            if (inputCommand== "odd")
            {
                predicateFindOddNumber(inputIntData);
            }
            else if (inputCommand== "even")
            {
                predicateFindEvenNumber(inputIntData);
            }

  
        }

        static bool FindOdd(List<int> tempListIntData)
        {
            List<int> tempPringData = new List<int>();
            for (int i = tempListIntData[0]; i <= tempListIntData[1]; i++)
            {

                if (i % 2 != 0)
                {
                    tempPringData.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",tempPringData));
            return true;

        }
        static bool FindEven(List<int> tempListIntData)
        {
            List<int> tempPringData = new List<int>();
            for (int i = tempListIntData[0]; i <= tempListIntData[1]; i++)
            {

                if (i % 2 == 0)
                {
                    tempPringData.Add(i);
                }


            }

            Console.WriteLine(string.Join(" ", tempPringData));
            return true;

        }
    }
}
