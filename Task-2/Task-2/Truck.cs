using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Truck : Vehicle
    {
        public double MaximumLoad { get; set; }

        public Truck(double engineСapacity, string transmissionType, int maximumSpeed, double maximumLoad)
        : base(engineСapacity, transmissionType, maximumSpeed)
        {
            MaximumLoad = maximumLoad;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Maximum load: {MaximumLoad}");
        }
    }
}
