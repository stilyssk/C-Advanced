using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> readSecFromInt = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int result = int.MaxValue;
            Func<int, int, int> findMin = Min;
            for (int i = 0; i < readSecFromInt.Count; i++)
            {
                result = findMin(readSecFromInt[i], result);
            }
            Console.WriteLine(result);
        }
        static int Min(int x, int y)
        {
            if (x < y)
                return x;
            return y;
        }
    }
}
