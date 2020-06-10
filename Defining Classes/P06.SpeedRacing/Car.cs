using System;
using System.Collections.Generic;
using System.Text;

namespace P06.SpeedRacing
{
    class Car
    {
        public Car(string model,double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance { get; set; }
        public void Drive(double distance)
        {
            if (distance*this.FuelConsumptionPerKilometer<=this.FuelAmount)
            {
                this.FuelAmount -= distance * this.FuelConsumptionPerKilometer;
                this.TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TraveledDistance}";
        }


    }
}
