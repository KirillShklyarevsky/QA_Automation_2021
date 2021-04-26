using System;

namespace Task_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Car car = new Car(1.9, "Robotic", 250, 5);
            Bus bus = new Bus(7.12, "Mechanical", 150, 90);
            Truck truck = new Truck(16, "Automatic", 120, 37000);
            Motorcycle motorcycle = new Motorcycle(1.103, "Automatic", 299, 198);

            VehicleFleet vehicleFleet = new VehicleFleet(new Vehicle[] { car, bus, truck, motorcycle });

            for (int i = 0; i < vehicleFleet.NumberOfVehiclesInVehicleFleet; i++)
            {
                Console.WriteLine(vehicleFleet[i].GetFullInfo());
            }
        }
    }
}
