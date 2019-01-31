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
            HashSet<string> hsFilters = new HashSet<string>();

            List<string> filterList = new List<string>();
            Func<List<string>, HashSet<char>, List<string>> funcFilter = (Names, tempHSFilters) =>
             {
                 List<string> tempNames = new List<string> ();
                 foreach (var name in Names)
                 {
                     bool pass = false;
                     foreach (var filter in tempHSFilters)
                     {
                         if (name[0]==filter)
                         {
                             pass = true;
                             break;
                         }
                     }
                     if (pass==false)
                     {
                         tempNames.Add(name);
                     }
                 }
                 return tempNames;
             };
            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (command[0]== "Print")
                {
                    break;
                }
                else
                {
                    if (command[0]== "Add filter")
                    {

                    }
                    else if (command[0]== "Remove filter")
                    {

                    }
                }
            }
        }
    }
}
