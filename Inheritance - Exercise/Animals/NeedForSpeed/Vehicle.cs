using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get => this.DefaultFuelConsumption; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }
        public virtual void Drive(double kilometers) 
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}
