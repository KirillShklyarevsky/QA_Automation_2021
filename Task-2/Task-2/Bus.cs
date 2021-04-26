using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Bus : Vehicle
    {
        public int SeatsNumber { get; set; }

        public Bus(double engineСapacity, string transmissionType, int maximumSpeed, int seatsNumber)
        : base(engineСapacity, transmissionType, maximumSpeed)
        {
            SeatsNumber = seatsNumber;
        }

        public override string GetFullInfo()
        {
            return (base.GetFullInfo() + $"Number of seats: {SeatsNumber}");
        }
    }
}
