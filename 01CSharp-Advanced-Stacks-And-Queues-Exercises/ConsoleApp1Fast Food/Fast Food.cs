using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputQuantity = int.Parse(Console.ReadLine());
            int[] orderArrayOfInt = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orderQuene = new Queue<int>();
            for (int i = 0; i < orderArrayOfInt.Count(); i++)
            {
                orderQuene.Enqueue(orderArrayOfInt[i]);
            }
            Queue<int> orderQueneTemp = new Queue<int>(orderQuene);

            int countOrder = 0;
            int biggestOrder = 0;
            bool flagOrdersFinish = true;
            while (orderQuene.Any())
            {
                if ((inputQuantity-orderQuene.Peek())>=0)
                {
                    int orderValue = orderQuene.Dequeue();
                    if (biggestOrder< orderValue)
                    {
                        biggestOrder = orderValue;
                    }
                    inputQuantity -= orderValue;
                    countOrder++;

                }
                else
                {
                    flagOrdersFinish = false;
                    break;
                }
            }
            Console.WriteLine(orderQueneTemp.Max());
            if (flagOrdersFinish)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orderQuene)}");
            }
        }
    }
}
