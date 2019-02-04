using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputIntData = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divider = int.Parse(Console.ReadLine());
            Func<List<int>, int, List<int>> funcReverceAndRemoveElemen = ReverceAndRemoveElemen;
            Console.WriteLine(string.Join(' ',funcReverceAndRemoveElemen(inputIntData,divider)));
        }

        static List<int> ReverceAndRemoveElemen(List<int> tempInputData,int divider)
        {
            Predicate<int> predicateRemove = x => x % divider == 0;
            for (int i = 0; i < tempInputData.Count; i++)
            {
                if (predicateRemove(tempInputData[i]))
                {
                    tempInputData.RemoveAt(i);
                    i--;
                }
            }
            tempInputData.Reverse();
            return tempInputData;
        }
    }
}
