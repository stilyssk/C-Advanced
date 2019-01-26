using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<float, int> storeCountDublicate = new Dictionary<float, int>();
            string inputString = Console.ReadLine();
            float[] inputNumber = inputString
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(float.Parse)
                .ToArray();
            foreach (float number in inputNumber)
            {
                if (storeCountDublicate.ContainsKey(number))
                {
                    storeCountDublicate[number]++;
                }
                else
                {
                    storeCountDublicate.Add(number, 1);
                }
            }
            foreach (var item in storeCountDublicate)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times  ");
            }
        }
    }
}
