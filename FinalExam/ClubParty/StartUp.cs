using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int capacityOfTheHall = int.Parse(Console.ReadLine());
            List<string> inputPeapleAndHall = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Queue<char> queneOfHall = new Queue<char>();
            //int countInCurrentHall = 0;
            List<int> peapleInCurrentHall = new List<int>();

            for (int i =inputPeapleAndHall.Count-1;i>=0;i--)
            {
                var peapleOrHall = inputPeapleAndHall[i];
                int newPeapleInHall = 0;
                bool isPeaple = int.TryParse(peapleOrHall, out newPeapleInHall);
                if (isPeaple)
                {
                    if (queneOfHall.Count!=0)
                    {
                        int countInCurrentHall = peapleInCurrentHall.Sum();

                        int newCountInHall = countInCurrentHall + newPeapleInHall;
                        if (capacityOfTheHall >= newCountInHall)
                        {
                            peapleInCurrentHall.Add(newPeapleInHall);
                            countInCurrentHall += newPeapleInHall;
                        }
                        else
                        {
                            Console.WriteLine($"{queneOfHall.Dequeue()} -> {string.Join(", ", peapleInCurrentHall)}");
                            peapleInCurrentHall = new List<int>();
                            if (queneOfHall.Count != 0)
                            {
                                peapleInCurrentHall.Add(newPeapleInHall); 
                            }
                        } 
                    }
                }
                else
                {
                    char newHall = peapleOrHall[0];
                    queneOfHall.Enqueue(newHall);

                }
            }
        }
    }
}
