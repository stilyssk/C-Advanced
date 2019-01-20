using System;
using System.Collections.Generic;
using System.Linq;
namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRepeatCount = int.Parse(Console.ReadLine());
            
            Stack<int> storeStack = new Stack<int>();
            for (int i = 0; i < inputRepeatCount; i++)
            {
                string inputString = Console.ReadLine();
                int[] commandArrayofInt = inputString
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                switch (commandArrayofInt[0])
                {
                    case 1:
                        storeStack.Push(commandArrayofInt[1]);
                        break;
                    case 2:
                        if (storeStack.Any())
                        {
                            storeStack.Pop();
                        }
                        break;
                    case 3:
                        if (storeStack.Any())
                        {
                            Console.WriteLine(storeStack.Max());

                        }
                        break;
                    case 4:
                        if (storeStack.Any())
                        {
                            Console.WriteLine(storeStack.Min());

                        }
                        break;
                    default:
                        break;
                }
            }
            //int[] printRestValue = new int[storeStack.Count];
            //for (int i =0;storeStack.Any();i++)
            //{
            //    printRestValue[i]= storeStack.Pop();
            //}
            Console.WriteLine(string.Join(", ", storeStack));
        }
    }
}
