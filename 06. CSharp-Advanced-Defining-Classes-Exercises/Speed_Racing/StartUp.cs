using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();
            for (int i = 0; i < repeat; i++)
            {
                List<string> inputDataOfNewCar = Console.ReadLine()
                    .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string model = inputDataOfNewCar[0];
                int fuelAmount = int.Parse(inputDataOfNewCar[1]);
                double fuelConsumptionFor1Kilometer = double.Parse(inputDataOfNewCar[2]);
                Car newCar = new Car(model, fuelAmount, fuelConsumptionFor1Kilometer);
                listOfCars.Add(newCar);
            }
            while (true)
            {
                List<string> inputDriveACar = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (inputDriveACar[0]== "End")
                {
                    break;
                }
                else if(inputDriveACar[0] == "Drive")
                {
                    string model = inputDriveACar[1];
                    int distance = int.Parse(inputDriveACar[2]);
                    for (int i = 0; i < listOfCars.Count; i++)
                    {
                        if (listOfCars[i].MyModel==model)
                        {
                            string reuslt = listOfCars[i].Drive(model, distance);
                            if (reuslt!=null)
                            {
                                Console.WriteLine(reuslt);
                            }
                        }
                    }
                }


            }
            for (int i = 0; i < listOfCars.Count; i++)
            {
                Console.WriteLine(listOfCars[i].PrintCarData());
            }

        }

    }
}
