using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(double engineСapacity, string transmissionType, int maximumSpeed, int numberOfDoors)
        : base(engineСapacity, transmissionType, maximumSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Number of doors: {NumberOfDoors}");
        }
    }
}
