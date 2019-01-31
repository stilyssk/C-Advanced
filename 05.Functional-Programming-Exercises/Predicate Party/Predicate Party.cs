using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                List<string> inputCommand = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                if (inputCommand[0]== "Party!")
                {
                    break;
                }
                Func<string, string, bool> funcStringStartWithLeter = (inputString, checkString) =>
                  {
                      
                      if (inputString.StartsWith(checkString))
                      {
                          return true;

                      }
                      return false;
                  };
                Func<string, string, bool> funcStringEndWithLeter = (inputString, checkString) =>
                {

                    if (inputString.EndsWith(checkString))
                    {
                        return true;

                    }
                    return false;
                };
                Func<string, string, string, bool> funcRemoveName = (name, command, searchString) =>
                   {
                       if (command== "StartsWith")
                       {
                           if (funcStringStartWithLeter(name,searchString))
                           {
                               return true;
                           }
                       }
                       else if (command== "EndsWith")
                       {
                           if (funcStringEndWithLeter(name, searchString))
                           {
                               return true;
                           }
                       }else if(command== "Length")
                       {
                           if (name.Length==int.Parse(searchString))
                           {
                               return true;
                           }
                       }
                       return false;
                   };
                switch (inputCommand[0])
                {
                    case "Remove":
                        for (int i = 0; i < inputNames.Count; i++)
                        {
                            if (funcRemoveName(inputNames[i],inputCommand[1],inputCommand[2]))
                            {
                                inputNames.RemoveAt(i);
                                i--;
                            }
                        }
                        break;
                    case "Double":
                        for (int i = 0; i < inputNames.Count; i++)
                        {
                            if (funcRemoveName(inputNames[i], inputCommand[1], inputCommand[2]))
                            {
                                inputNames.Insert(i, inputNames[i]);
                                i++;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            if (inputNames.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", inputNames)} are going to the party!");


            }
        }
    }
}
