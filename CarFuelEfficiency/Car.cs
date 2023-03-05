using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFuelEfficiency
{
    public class Car
    {
        private double fuelEfficiency { get; set; }
        private double fuelLevel { get; set; }

        public Car(double efficiency)
        {
            fuelEfficiency = efficiency;
            fuelLevel = 0;
        }
        
        public void Drive(double distance)
        {
            fuelLevel -= distance / fuelEfficiency;
            Console.WriteLine("This car has drove " + distance + " km");
        }

        public double GetFuelLevel()
        {
            Console.WriteLine("After driving this distance, the fuel remaining: " + fuelLevel + " litres");
            return fuelLevel;
        }

        public void AddFuel(double amount)
        {
            fuelLevel += amount;
            Console.WriteLine("This car has fuel level of " + amount + " litres");
        }
    }
}
