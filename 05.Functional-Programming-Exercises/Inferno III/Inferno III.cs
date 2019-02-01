using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputIntNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            HashSet<int> hsSumLeft = new HashSet<int>();
            HashSet<int> hsSumLeftRight = new HashSet<int>();
            HashSet<int> hsSumRight = new HashSet<int>();

            while (true)
            {
                List<string> inputCommand = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (inputCommand[0] == "Forge")
                {
                    break;
                }
                else
                {
                    string commandExcludeReverse = inputCommand[0];
                    string connditionCommand = inputCommand[1];
                    int filterData = int.Parse(inputCommand[2]);
                    if (commandExcludeReverse == "Exclude")
                    {

                        switch (connditionCommand)
                        {
                            case "Sum Left":
                                hsSumLeft.Add(filterData);
                                break;
                            case "Sum Right":
                                hsSumRight.Add(filterData);
                                break;
                            case "Sum Left Right":
                                hsSumLeftRight.Add(filterData);
                                break;
                            default:
                                break;
                        }
                    }
                    else if (commandExcludeReverse == "Reverse")
                    {
                        switch (connditionCommand)
                        {
                            case "Sum Left":
                                if (hsSumLeft.Contains(filterData))
                                {
                                    hsSumLeft.Remove(filterData);

                                }
                                break;
                            case "Sum Right":
                                if (hsSumRight.Contains(filterData))
                                {
                                    hsSumRight.Remove(filterData);

                                }
                                break;
                            case "Sum Left Right":
                                if (hsSumLeftRight.Contains(filterData))
                                {
                                    hsSumLeftRight.Remove(filterData);

                                }
                                break;
                            default:
                                break;
                        }
                    }
                }

            }
            Func<List<int>, HashSet<int>, List<int>> funcSumLeft = (listOfInt, filter) =>
            {
                foreach (var filterInt in filter)
                {
                    
                    for (int i = 0; i < listOfInt.Count; i++)
                    {
                        int left = 0;
                        if (i>0)
                        {
                            left = listOfInt[i - 1];
                        }
                        int sum = left + listOfInt[i];
                        if (sum==filterInt)
                        {
                            listOfInt.RemoveAt(i);
                            if (i!=0)
                            {
                                i--;

                            }
                        }
                    }
                }
                return listOfInt;
            };
            Func<List<int>, HashSet<int>, List<int>> funcSumRight = (listOfInt, filter) =>
            {
                foreach (var filterInt in filter)
                {
                    for (int i = 0; i < listOfInt.Count; i++)
                    {
                        int right = 0;

                        if (i < listOfInt.Count - 1)
                        {
                            right = listOfInt[i + 1];
                        }
                        int sum = listOfInt[i] + right;
                        if (sum == filterInt)
                        {
                            listOfInt.RemoveAt(i);
                            i--;
                        }
                    }
                }
                return listOfInt;
            };
            Func<List<int>, HashSet<int>, List<int>> funcSumLeftRight = (listOfInt, filter) =>
            {
                foreach (var filterInt in filter)
                {
                    for (int i = 0; i < listOfInt.Count; i++)
                    {
                        int left = 0;
                        int right = 0;
                        if (i > 0)
                        {
                            left = listOfInt[i - 1];
                        }
                        if (i < listOfInt.Count - 1)
                        {
                            right = listOfInt[i + 1];
                        }
                        int sum = left + listOfInt[i] + right;
                        if (sum == filterInt)
                        {
                            listOfInt.RemoveAt(i);
                            i--;
                        }
                    }
                }
                
                return listOfInt;
            };
            inputIntNumbers = funcSumLeft(inputIntNumbers, hsSumLeft);
            inputIntNumbers = funcSumRight(inputIntNumbers, hsSumRight);
            inputIntNumbers = funcSumLeftRight(inputIntNumbers, hsSumLeftRight);
            Console.WriteLine(string.Join(' ', inputIntNumbers));
        }
    }
}
