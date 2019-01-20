using System;
using System.Collections.Generic;
using System.Linq;
namespace Basic_Stack_Operations
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
            Stack<int> stackData = new Stack<int>();
            for (int i = 0; i < inputCommand[0]; i++)
            {
                stackData.Push(inputData[i]);
            }
            for (int i = 0; i < inputCommand[1]; i++)
            {
                stackData.Pop();
            }
            int min = int.MaxValue;
            bool flagFindNumber = false;
            bool flagEmpty = false;
            if (stackData.Count==0)
            {
                flagEmpty = true;
            }
            while (stackData.Any())
            {
                int tempParameter = stackData.Pop();
                if (min>tempParameter)
                {
                    min = tempParameter;
                }
                if (tempParameter==inputCommand[2])
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
