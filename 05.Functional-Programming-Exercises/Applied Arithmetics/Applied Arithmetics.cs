using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputIntData = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<int, int> addCommand = x=>x+1 ;
            Func<int, int> subtractCommand = x => x - 1;
            Func<int, int> multiplyCommand = x => x*2;

            Func<List<int>, List<int>> funcAdd = Add;
            Func<List<int>, List<int>> funcSubtract = Subtract;
            Func<List<int>, List<int>> funcMultiply = Multiply;

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand== "end")
                {
                    break;
                }
                else
                {
                    switch (inputCommand)
                    {
                        case "add":
                            //inputIntData=funcAdd(inputIntData);
                            for (int i = 0; i < inputIntData.Count; i++)
                            {

                                inputIntData[i]=addCommand(inputIntData[i]);
                            }
                            break;
                        case "subtract":
                            //inputIntData = funcSubtract(inputIntData);
                            for (int i = 0; i < inputIntData.Count; i++)
                            {

                                inputIntData[i] = subtractCommand(inputIntData[i]);
                            }
                            break;
                        case "multiply":
                            //inputIntData = funcMultiply(inputIntData);
                            for (int i = 0; i < inputIntData.Count; i++)
                            {

                                inputIntData[i] = multiplyCommand(inputIntData[i]);
                            }
                            break;
                        case "print":
                            Console.WriteLine(string.Join(' ',inputIntData));
                            break;
                        default:
                            break;
                    }
                }

            }

        }

        static List<int> Add(List<int> tempInputData)
        {

            for (int i = 0; i < tempInputData.Count; i++)
            {
                tempInputData[i] += 1;
            }
            return tempInputData;
        }

        static List<int> Subtract(List<int> tempInputData)
        {

            for (int i = 0; i < tempInputData.Count; i++)
            {
                tempInputData[i] -= 1;
            }
            return tempInputData;
        }

        static List<int> Multiply(List<int> tempInputData)
        {

            for (int i = 0; i < tempInputData.Count; i++)
            {
                tempInputData[i] *= 2;
            }
            return tempInputData;
        }

    }
}
