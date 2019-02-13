using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();
            for (int i = 0; i < repeat; i++)
            {
                List<string> inputCarData = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string model = inputCarData[0];
                Engine newEngine = new Engine();
                newEngine.Speed = int.Parse(inputCarData[1]);
                newEngine.Power = int.Parse(inputCarData[2]);
                Cargo newCargo = new Cargo();
                newCargo.Weight = int.Parse(inputCarData[3]);
                newCargo.Type = inputCarData[4];
                int indexDataTire = 5;
                Tire[] newTires = new Tire[4];
                for (int j = 0; j < newTires.Length; j++)
                {
                    newTires[j] = new Tire();
                    newTires[j].Pressure = double.Parse(inputCarData[indexDataTire]);
                    indexDataTire++;
                    newTires[j].Age = int.Parse(inputCarData[indexDataTire]);
                    indexDataTire++;
                }
                Car newCar = new Car(newTires, newCargo, newEngine, model);

                listOfCars.Add(newCar);
            }
            string inputCommand = Console.ReadLine();
            if (inputCommand == "fragile")
            {
                foreach (var currentCar in listOfCars)
                {
                    if (currentCar.Cargo.Type == "fragile")
                    {
                        bool flagPresuareIsLess1 = false;
                        for (int i = 0; i < currentCar.Tires.Length; i++)
                        {
                            if (currentCar.Tires[i].Pressure <1)
                            {
                                flagPresuareIsLess1 = true;
                                break;
                            }

                        }
                        if (flagPresuareIsLess1)
                        {
                            Console.WriteLine(currentCar.Model);
                        }
                    }
                }
            }
            else if (inputCommand == "flamable")
            {
                foreach (var currentCar in listOfCars)
                {
                    if (currentCar.Cargo.Type == "flamable"&&currentCar.Engine.Power>250)
                    {
                        Console.WriteLine(currentCar.Model);

                    }
                }
            }
        }
    }
}
