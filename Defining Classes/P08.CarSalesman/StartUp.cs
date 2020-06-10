using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();
                var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AddingEngine(engines);
            }
            var j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                AddingCar(engines, cars);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }

        private static void AddingCar(HashSet<Engine> engines, List<Car> cars)
        {
            Car car = null;
            var carArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var model = carArgs[0];
            Engine engine = engines.First(e => e.Model == carArgs[1]);
            if (carArgs.Length == 2)
            {
                car = new Car(model, engine);
            }
            else if (carArgs.Length == 3)
            {
                double weight;
                bool isWeight = double.TryParse(carArgs[2], out weight);
                if (isWeight)
                {
                    car = new Car(model, engine, weight);
                }
                else
                {
                    car = new Car(model, engine, carArgs[2]);
                }
            }
            else if (carArgs.Length == 4)
            {
                var weight = double.Parse(carArgs[2]);
                var color = carArgs[3];
                car = new Car(model, engine, weight, color);
            }
            if (car != null)
            {
                cars.Add(car);
            }
        }

        private static void AddingEngine(HashSet<Engine> engines)
        {
            Engine engine = null;
            var engineArg = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var model = engineArg[0];
            var power = int.Parse(engineArg[1]);
            if (engineArg.Length == 4)
            {
                var displacemnt = int.Parse(engineArg[2]);
                var efficiency = engineArg[3];
                engine = new Engine(model, power, displacemnt, efficiency);
            }
            else if (engineArg.Length == 2)
            {
                engine = new Engine(model, power);
            }
            else if (engineArg.Length == 3)
            {
                int displacement;
                bool isDisplacemnt = int.TryParse(engineArg[2],
                    out displacement);
                if (isDisplacemnt)
                {
                    engine = new Engine(model, power, displacement);
                }
                else
                {
                    engine = new Engine(model, power, engineArg[2]);
                }
            }
            if (engine != null)
            {
                engines.Add(engine);
            }
        }
    }
}
