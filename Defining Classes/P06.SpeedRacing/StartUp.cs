using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SpeedRacing
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
               
                var carArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var model = carArg[0];
                var fuelAmount = double.Parse(carArg[1]);
                var fuelConsumption= double.Parse(carArg[2]);
                var car = new Car(model, fuelAmount,fuelConsumption);
                cars.Add(car);
            }
            string comand;
            while ((comand=Console.ReadLine())!="End")
            {
                var carArg = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var model = carArg[1];
                var amountOfKm = double.Parse(carArg[2]);
                var car = cars.FirstOrDefault(c => c.Model == model);
                if (car!=null)
                {
                    car.Drive(amountOfKm);
                }

            }
            foreach (var car in cars)
            {
                Console.WriteLine(car); 
            }
        }
    }
}
