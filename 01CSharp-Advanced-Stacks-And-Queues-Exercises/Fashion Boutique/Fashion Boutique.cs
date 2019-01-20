using System;
using System.Collections.Generic;
using System.Linq;
namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> storeStack = new Stack<int>();

            string inputString = Console.ReadLine();
            int[] boxContainerCapacity = inputString
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < boxContainerCapacity.Length; i++)
            {
                storeStack.Push(boxContainerCapacity[i]);
            }
            //storeStack = new Stack<int>(storeStack.Reverse());
            int inputRackCapacity = int.Parse(Console.ReadLine());
            int countOfBoxes = 0;
            while (storeStack.Any())
            {
                countOfBoxes++;
                for (int i = 0; i <= inputRackCapacity&&storeStack.Any();i += storeStack.Peek())
                {
                    i+=storeStack.Pop();
                    
                    if (storeStack.Count==0)
                    {
                        break;
                    }
                    
                }
                
            }
            Console.WriteLine(countOfBoxes);
        }
    }
}
