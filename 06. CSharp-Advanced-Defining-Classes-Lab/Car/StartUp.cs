﻿// <auto-generated />
namespace CarManufacturer
{
    using System;
    using Car;

    /// <summary>
    /// Main program class
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Main function
        /// </summary>
        public static void Main()
        {
            var car = new Car()
            {
                Make = "VW",
                Model = "MK3",
                Year = 1992
            };
            Console.WriteLine($"Make:{car.Make}");
            Console.WriteLine($"Model:{car.Model}");
            Console.WriteLine($"Year:{car.Year}");
        }
    }
}
