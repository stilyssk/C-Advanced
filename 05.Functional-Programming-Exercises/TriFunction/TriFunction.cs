using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            List<string> inputNames = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Action<int,string, int> actionPrintResult = (actionInputNumber,actionName, actionSum) =>
             {
                 if (actionInputNumber <= actionSum)
                 {
                     Console.WriteLine(actionName);

                 }
             };
            Action<List<string>, int> actionFindName = (actionInputNames, actionInputNumber) =>
             {
                 foreach (var name in actionInputNames)
                 {
                     int sum = 0;
                     for (int i = 0; i < name.Length; i++)
                     {
                         sum += name[i];
                     }
                     actionPrintResult(actionInputNumber, name, sum);
                 }
             };
            actionFindName(inputNames, inputNumber);

        }
    }
}
