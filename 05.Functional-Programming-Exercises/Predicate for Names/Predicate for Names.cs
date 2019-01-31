using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLeters = int.Parse(Console.ReadLine());

            List<string> inputNameData = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Func<string, int, string> funcFilterNameByLenght = (x, y) =>
              {

                  if (x.Length <= y)
                  {
                      return x;
                  }
                  return "";

              };
            for (int i = 0; i < inputNameData.Count; i++)
            {
                if (funcFilterNameByLenght(inputNameData[i],numberOfLeters)!="")
                {
                    Console.WriteLine(inputNameData[i]);
                }
            }
        }
    }
}
