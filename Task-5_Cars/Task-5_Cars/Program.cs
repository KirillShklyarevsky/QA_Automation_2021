using System;
using System.Collections.Generic;

namespace Task_5_Cars
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() { new Car(Brand.Audi, "A8", BodyType.Hatchback, EngineType.Petrol, 500000, 8),
                                               new Car(Brand.BMW, "4", BodyType.Coupe, EngineType.Diesel, 600000, 3.0),
                                               new Car(Brand.Buick, "Encore", BodyType.Minivan, EngineType.Gas, 300000, 1.8),
                                               new Car(Brand.Maserati, "Spyder", BodyType.Cabriolet, EngineType.Petrol, 450000, 3.5),
                                               new Car(Brand.Subaru, "Legacy", BodyType.Sedan, EngineType.Rotor, 350000, 2.5)};

            CarDealer carDealer = new CarDealer(cars);

            Console.WriteLine(carDealer.GetAverage(Helper.CountAverageEngineСapacity));
            Console.WriteLine(carDealer.GetAverage(Helper.CountAveragePrice));
        }
    }
}
