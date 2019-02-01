using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNames = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            HashSet<string> startsWith = new HashSet<string>();
            HashSet<string> endsWith = new HashSet<string>();
            HashSet<int> length = new HashSet<int>();
            HashSet<string> contains = new HashSet<string>();

            while (true)
            {
                List<string> inputCommand = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (inputCommand[0]== "Print")
                {
                    break;
                }
                else
                {
                    string addRemoveCommand = inputCommand[0];
                    string connditionCommand = inputCommand[1];
                    string filterData = inputCommand[2];
                    if (addRemoveCommand == "Add filter")
                    {

                        switch (connditionCommand)
                        {
                            case "Starts with":
                                startsWith.Add(filterData);
                                break;
                            case "Ends with":
                                endsWith.Add(filterData);
                                break;
                            case "Length":
                                length.Add(int.Parse(filterData));
                                break;
                            case "Contains":
                                contains.Add(filterData);
                                break;
                            default:
                                break;
                        }
                    }
                    else if (addRemoveCommand == "Remove filter")
                    {
                        switch (connditionCommand)
                        {
                            case "Starts with":
                                if (startsWith.Contains(filterData))
                                {
                                    startsWith.Remove(filterData);

                                }
                                break;
                            case "Ends with":
                                if (endsWith.Contains(filterData))
                                {
                                    endsWith.Remove(filterData);

                                }
                                break;
                            case "Length":
                                if (length.Contains(int.Parse(filterData)))
                                {
                                    length.Remove(int.Parse(filterData));

                                }
                                break;
                            case "Contains":
                                if (contains.Contains(filterData))
                                {
                                    contains.Remove(filterData);

                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            Func<List<string>, HashSet<string>, List<string>> funcStartWith = (listOfNames, filter) =>
              {
                  foreach (var filterString in filter)
                  {
                      for (int i = 0; i < listOfNames.Count; i++)
                      {
                          if (listOfNames[i][0]==filterString[0])
                          {
                              listOfNames.RemoveAt(i);
                              i--;
                          }
                      }
                  }
                  return listOfNames;
              };
            Func<List<string>, HashSet<string>, List<string>> funcEndWith = (listOfNames, filter) =>
            {
                foreach (var filterString in filter)
                {
                    for (int i = 0; i < listOfNames.Count; i++)
                    {
                        int count = listOfNames[i].Length;
                        if (listOfNames[i][count-1] == filterString[0])
                        {
                            listOfNames.RemoveAt(i);
                            i--;
                        }
                    }
                }
                return listOfNames;
            };
            Func<List<string>, HashSet<string>, List<string>> funcContains = (listOfNames, filter) =>
            {
                foreach (var filterString in filter)
                {
                    for (int i = 0; i < listOfNames.Count; i++)
                    {
                        if (listOfNames[i].Contains(filterString))
                        {
                            listOfNames.RemoveAt(i);
                            i--;
                        }
                    }
                }
                return listOfNames;
            };
            Func<List<string>, HashSet<int>, List<string>> funcLength = (listOfNames, filter) =>
            {
                foreach (var filterInt in filter)
                {
                    for (int i = 0; i < listOfNames.Count; i++)
                    {
                        if (listOfNames[i].Length==(filterInt))
                        {
                            listOfNames.RemoveAt(i);
                            i--;
                        }
                    }
                }
                return listOfNames;
            };
            inputNames = funcStartWith(inputNames, startsWith);
            inputNames = funcEndWith(inputNames, endsWith);
            inputNames = funcLength(inputNames, length);
            inputNames = funcContains(inputNames, contains);
            Console.WriteLine(string.Join(' ',inputNames));
        }
    }
}
