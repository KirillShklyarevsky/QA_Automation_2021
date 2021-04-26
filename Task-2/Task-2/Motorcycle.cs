using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Motorcycle : Vehicle
    {
        public double Weight { get; set; }

        public Motorcycle(double engineСapacity, string transmissionType, int maximumSpeed, double weight)
        : base(engineСapacity, transmissionType, maximumSpeed)
        {
            Weight = weight;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Weight of motorcycle : {Weight}");
        }
    }
}
