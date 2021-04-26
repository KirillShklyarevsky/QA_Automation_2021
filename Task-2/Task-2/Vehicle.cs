using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public abstract class Vehicle
    {
        public double EngineCapacity { get; set; }

        public string TransmissionType { get; set; }

        public int MaximumSpeed { get; set; }


        public Vehicle(double engineСapacity, string transmissionType, int maximumSpeed)
        {
            EngineCapacity = engineСapacity;
            TransmissionType = transmissionType;
            MaximumSpeed = maximumSpeed;
        }

        public virtual string GetFullInfo()
        {
            return "Engine capacity: " + $"{EngineCapacity} " + "Transmission type: " + $"{TransmissionType} " + "Maximum speed: " + $"{MaximumSpeed} ";
        }
    }
}
