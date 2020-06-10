using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < n; i++)
            {
                var carArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var model = carArg[0];

                var engineSpeed = int.Parse(carArg[1]);
                var enginePower = int.Parse(carArg[2]);

                var cargoWeight = int.Parse(carArg[3]);
                var cargoType = carArg[4];

                var tire1Pressure = double.Parse(carArg[5]);
                var tire1Age = int.Parse(carArg[6]);
                var tire2Pressure = double.Parse(carArg[7]);
                var tire2Age = int.Parse(carArg[8]);
                var tire3Pressure = double.Parse(carArg[9]);
                var tire3Age = int.Parse(carArg[10]);
                var tire4Pressure = double.Parse(carArg[11]);
                var tire4Age = int.Parse(carArg[12]);
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                    tire1Pressure, tire1Age,
                    tire2Pressure, tire2Age,
                     tire3Pressure, tire3Age,
                    tire4Pressure, tire4Age);
                cars.Add(car);
            }
            var comand = Console.ReadLine();
            if (comand== "fragile")
            {
                HashSet<Car> result = cars.Where(c => c.Cargo.Type == "fragile" &&
                  c.Tires.Any(t => t.Pressure < 1))
                    .ToHashSet();
                Console.WriteLine(string.Join(Environment.NewLine,result));
            }
            else if (comand== "flamable")
            {
                HashSet<Car> result = cars.Where(c => c.Cargo.Type == "flamable" &&
                  c.Engine.Power>250)
                    .ToHashSet();
                Console.WriteLine(string.Join(Environment.NewLine, result));
            }
        }
           
            
    }
}
