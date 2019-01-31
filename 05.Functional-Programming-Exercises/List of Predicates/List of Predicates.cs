using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLimit = int.Parse(Console.ReadLine());
            int[] inputIntNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> listOfInt = new List<int>();
            Func<int, int, bool> funcExistDivide = (x, y) =>
              {
                  if (x % y == 0)
                  {
                      return  true;
                  }
                  return false;
              };
            for (int i = 1; i <= inputLimit; i++)
            {
                bool pass = false;
                for (int j = 0; j < inputIntNumbers.Length; j++)
                {
                    pass = false;
                    if (funcExistDivide(i,inputIntNumbers[j]))
                    {
                        pass = true;
                    }
                    else
                    {
                        break;
                    }
                }
                if (pass)
                {
                    listOfInt.Add(i);
                }

            }

            Console.WriteLine(string.Join(' ',listOfInt));
        }
    }
}
