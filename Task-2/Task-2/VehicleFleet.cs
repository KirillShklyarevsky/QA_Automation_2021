using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class VehicleFleet
    {
        private Vehicle[] _vehicles;

        public Vehicle this[int i]
        {
            get 
            {
                return _vehicles[i]; 
            }
            set 
            {
                _vehicles[i] = value;
            }
        }

        public int NumberOfVehiclesInVehicleFleet { get; }

        public VehicleFleet(Vehicle[] vehicles)
        {
            _vehicles = vehicles;
            NumberOfVehiclesInVehicleFleet = _vehicles.Length;
        }
    }
}
