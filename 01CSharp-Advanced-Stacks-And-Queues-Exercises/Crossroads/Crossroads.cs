using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Crossroads
    {
        static void Main(string[] args)
        {
            int inputgreenLight = int.Parse(Console.ReadLine());
            int inputfreeWindow = int.Parse(Console.ReadLine());
            Queue<string> queneCarsWaiting = new Queue<string>();
            int carPasset = 0;
            bool flagNoCrash = true;
            while (flagNoCrash)
            {
                int greenLight = inputgreenLight;
                int freeWindow = inputfreeWindow;
                string inputCommand = Console.ReadLine();
                if (inputCommand == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{carPasset} total cars passed the crossroads.");
                    break;
                }
                else
                {
                    if (inputCommand == "green")
                    {

                        while (greenLight!=0&&queneCarsWaiting.Any())
                        {
                            bool currentCarPassed = false;
                            int leghtOfCar = queneCarsWaiting.Peek().Length;
                            string currentCar = queneCarsWaiting.Dequeue();
                            if (greenLight >= leghtOfCar)
                            {
                                greenLight -= leghtOfCar;
                                carPasset++;
                                currentCarPassed = true;
                            }
                            if(!currentCarPassed)
                            {
                                int restOfTheCar = leghtOfCar - greenLight;
                                if (freeWindow >= restOfTheCar)
                                {
                                    carPasset++;
                                    greenLight = 0;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar.ElementAt( restOfTheCar+greenLight+1 - freeWindow)}.");
                                    greenLight = 0;

                                    flagNoCrash = false;
                                }
                            } 
                        }
                    }
                    else
                    {
                        queneCarsWaiting.Enqueue(inputCommand);
                    }
                }

            }
        }
    }
}
