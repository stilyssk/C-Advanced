using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Repeat = int.Parse(Console.ReadLine());
            string collectString = "";
            Stack<string> oldState = new Stack<string>();
            for (int i = 0; i < Repeat; i++)
            {
                string[] inputString = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (inputString[0])
                {
                    case "1":
                        oldState.Push(collectString);               
                        collectString += inputString[1];
                        break;
                    case "2":
                        oldState.Push(collectString);
                        int count = int.Parse(inputString[1]);
                        collectString= collectString.Remove(collectString.Length-count, count);
                        break;
                    case "3":
                        int indexOfChar = int.Parse(inputString[1]);
                        Console.WriteLine(collectString[indexOfChar-1]);
                        break;
                    case "4":
                        if (oldState.Any())
                        {
                            collectString = oldState.Pop();

                        }
                        break;
                    default:
                        break;
                }               
            }
        }
    }
}
