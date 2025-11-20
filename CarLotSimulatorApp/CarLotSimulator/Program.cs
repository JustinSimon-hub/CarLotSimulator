using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a car lot
            CarLot lot = new CarLot();

            // Car #1 (standard property-by-property)
            Car Car1 = new Car();
            Car1.Year = 2020;
            Car1.Make = "Toyota";
            Car1.Model = "Corolla";
            Car1.EngineNoise = "Vroom";
            Car1.HonkNoise = "Beep Beep";
            Car1.IsDriveable = true;
            lot.Cars.Add(Car1);

            // Car #2 (object initializer)
            Car Car2 = new Car()
            {
                Year = 2018,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Zoom",
                HonkNoise = "Honk Honk",
                IsDriveable = true
            };
            lot.Cars.Add(Car2);

            // Car #3 (using constructor)
            Car Car3 = new Car(2015, "Ford", "Focus", "Rumble", "Toot Toot", false);
            lot.Cars.Add(Car3);

            // Iterate and display all cars
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
