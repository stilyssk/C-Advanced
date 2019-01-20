using System;
using System.Collections.Generic;
using System.Linq;
namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCommand = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputData = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> stackData = new Queue<int>();
            for (int i = 0; i < inputCommand[0]; i++)
            {
                stackData.Enqueue(inputData[i]);
            }
            for (int i = 0; i < inputCommand[1]; i++)
            {
                stackData.Dequeue();
            }
            int min = int.MaxValue;
            bool flagFindNumber = false;
            bool flagEmpty = false;
            if (stackData.Count == 0)
            {
                flagEmpty = true;
            }
            while (stackData.Any())
            {
                int tempParameter = stackData.Dequeue();
                if (min > tempParameter)
                {
                    min = tempParameter;
                }
                if (tempParameter == inputCommand[2])
                {
                    flagFindNumber = true;
                    break;
                }
            }
            if (!flagEmpty)
            {
                if (flagFindNumber)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(min);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
