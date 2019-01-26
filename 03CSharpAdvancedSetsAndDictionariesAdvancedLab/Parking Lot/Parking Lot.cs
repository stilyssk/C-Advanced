using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            while (true)
            {
                string[] inputData = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = inputData[0];
                if (command=="END")
                {
                    break;
                }
                else
                {
                    string number = inputData[1];
                    if (command=="IN")
                    {
                        carNumbers.Add(number);
                    }
                    else if (command=="OUT")
                    {
                        carNumbers.Remove(number);
                    }
                }


            }

            if (carNumbers.Count()!=0)
            {
                foreach (var currentNumber in carNumbers)
                {
                    Console.WriteLine(currentNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
