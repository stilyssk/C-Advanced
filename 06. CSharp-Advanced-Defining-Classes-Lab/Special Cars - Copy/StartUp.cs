namespace CarManufacturer
{
    using System;
    using Car;
    using Tire;
    using Engine;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {

            string inputCommand;
            List<Tire[]> listOfTires = new List<Tire[]>();
            List<Engine> listOfEngine = new List<Engine>();
            List<Car> listOfCar = new List<Car>();
            while (true)
            {
                inputCommand = Console.ReadLine();
                if (inputCommand== "No more tires")
                {
                    break;
                }
                else
                {

                    var tempData = inputCommand
                        .Split(new[] {" " },StringSplitOptions.RemoveEmptyEntries)
                        .ToList();


                    int indexOfInputTire = 0;
                    Tire[] tireInOneCar = new Tire[4];

                    for (int i = 0; i < 4; i++)
                    {
                        int tireYear = int.Parse(tempData[indexOfInputTire]);
                        indexOfInputTire++;
                        double tirePressure = double.Parse(tempData[indexOfInputTire]);
                        indexOfInputTire++;
                        Tire newTire = new Tire(tireYear, tirePressure);
                        tireInOneCar[i] = newTire;
                    }
                    listOfTires.Add(tireInOneCar);


                }
            }

            while (true)
            {
                inputCommand = Console.ReadLine();
                if (inputCommand == "Engines done")
                {
                    break;
                }
                else
                {
                    var tempData = inputCommand
                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    int horsePower = int.Parse(tempData[0]);
                    double cubicCapacity = double.Parse(tempData[1]);
                    Engine newEngine = new Engine(horsePower, cubicCapacity);
                    listOfEngine.Add(newEngine);

                }
            }

            while (true)
            {
                inputCommand = Console.ReadLine();
                if (inputCommand == "Show special")
                {
                    break;
                }
                else
                {
                    var tempData = inputCommand
                        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    string carName = tempData[0];
                    string carModel = tempData[1];
                    int carYear = int.Parse(tempData[2]);
                    double fuelQuantity = double.Parse(tempData[3]);
                    double fuelConsumption = double.Parse(tempData[4]);
                    int indexEngine = int.Parse(tempData[5]);
                    int indexTire = int.Parse(tempData[6]);

                    Car newCar = new Car
                        (
                        carName,
                        carModel,
                        carYear,
                        fuelConsumption,
                        fuelQuantity,
                        listOfEngine[indexEngine],
                        listOfTires[indexTire]
                        );
                    listOfCar.Add(newCar);
                }
            }
            foreach (var currentCar in listOfCar)
            {
                currentCar.Drive(20);
            }
            listOfCar = listOfCar.Where(x => x.Year>=2017).Where(x=>x.Engine.HorsePower>330).ToList();

            foreach (var currentCar in listOfCar)
            {
                Console.WriteLine(currentCar.WhoAmI());
            }
            
        }
    }
}
