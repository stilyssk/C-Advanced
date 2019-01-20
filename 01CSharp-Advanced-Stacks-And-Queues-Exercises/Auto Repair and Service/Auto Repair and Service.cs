using System;
using System.Collections.Generic;
using System.Linq;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputCarArray = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> carInformationQuene = new Queue<string>();
            Stack<string> tempCarServed = new Stack<string>();

            foreach (var item in inputCarArray)
            {
                carInformationQuene.Enqueue(item);
            }
            Queue<string> carServedQuene = new Queue<string>();

            while (true)
            {
                string[] inputcommant = Console.ReadLine()
                    .Split(new string[] {"-"},StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inputcommant[0]=="End")
                {
                    break;
                }
                switch (inputcommant[0])
                {
                    case "Service":
                        if (carInformationQuene.Any())
                        {
                            Console.WriteLine($"Vehicle {carInformationQuene.Peek()} got served.");
                            carServedQuene.Enqueue(carInformationQuene.Dequeue()); 
                        }

                        break;
                    case "CarInfo":
                        if (carServedQuene.Contains(inputcommant[1]))
                        {
                            Console.WriteLine("Served.");
                        }
                        else
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        break;
                    case "History":
                        tempCarServed = new Stack<string>(carServedQuene);
                        Console.WriteLine(string.Join(", ", tempCarServed));
                        break;

                    default:
                        break;
                }

            }
            if (carInformationQuene.Any())
            {
                Queue<string> tempCarServedQuene = new Queue<string>(carInformationQuene);
                Console.WriteLine($"Vehicles for service: { string.Join(", ", tempCarServedQuene)}");
            }

            tempCarServed = new Stack<string>(carServedQuene);
            Console.WriteLine($"Served vehicles: { string.Join(", ", tempCarServed)}");
        }
    }
}
