using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Queue<char> inputQuene = new Queue<char>(inputString);
            Stack<char> inputStack = new Stack<char>(inputString);
            bool flagNoPair = false;
            while (inputQuene.Any())
            {
                switch (inputQuene.Dequeue())
                {
                    case '}':
                        if (!(inputStack.Pop() == '{'))
                        {
                            flagNoPair = true;
                        }
                        break;
                    case '{':
                        if (!(inputStack.Pop() == '}'))
                        {
                            flagNoPair = true;
                        }
                        break;
                    case '[':
                        if (!(inputStack.Pop() == ']'))
                        {
                            flagNoPair = true;
                        }
                        break;
                    case ']':
                        if (!(inputStack.Pop() == '['))
                        {
                            flagNoPair = true;
                        }
                        break;
                    case '(':
                        if (!(inputStack.Pop() == ')'))
                        {
                            flagNoPair = true;
                        }
                        break;
                    case ')':
                        if (!(inputStack.Pop() == '('))
                        {
                            flagNoPair = true;
                        }
                        break;
                    default:
                        inputStack.Pop();
                        break;
                } 
            }
            if (flagNoPair)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
