using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.Capacity = capacity;
        }

        public int Capacity
        {
            set
            {
                this.capacity = value;
            }
        }



        public int Count
        {
            get
            {
                return this.cars.Count;
            }
        }
        public string AddCar(Car car)
        {
            string result = null;

            if (!cars.Contains(car))
            {
                if (this.capacity<cars.Count)
                {
                    result = "Parking is full!";
                }
                else
                {
                    cars.Add(car);
                    result = $"Successfully added new car { car.Make } { car.RegistrationNumber}";
                    
                }
                
            }
            else
            {
                result = $"Car with that registration number, already exists!";
            }
            return result;
        }

        public string RemoveCar(string registrationNumber)
        {
            string result = null;
            var exist = cars.Find(x => x.RegistrationNumber == registrationNumber);
            
            if (exist!=null)
            {
                int index = cars.FindIndex(x => x.RegistrationNumber == registrationNumber);
                cars.RemoveAt(index);
                result = $"Successfully removed { registrationNumber}";
                
            }
            else
            {
                result = "Car with that registration number, doesn't exist!";
            }
            return result;
        }

        public Car GetCar(string registrationNumber)
        {
            int index = cars.FindIndex(x => x.RegistrationNumber == registrationNumber);

            return cars[index];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                RemoveCar(number);
            }
        }
    }
}
