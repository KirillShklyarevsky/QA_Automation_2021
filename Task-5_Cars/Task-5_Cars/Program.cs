using System;
using System.Collections.Generic;

namespace Task_5_Cars
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() { new Car(Brand.Audi, "A8", BodyType.Hatchback, EngineType.Petrol, 50000, 8),
                                               new Car(Brand.BMW, "4", BodyType.Coupe, EngineType.Diesel, 60000, 3.0),
                                               new Car(Brand.Buick, "Encore", BodyType.Minivan, EngineType.Gas, 30000, 1.8),
                                               new Car(Brand.Maserati, "Spyder", BodyType.Cabriolet, EngineType.Petrol, 450000, 3.5),
                                               new Car(Brand.Subaru, "Legacy", BodyType.Sedan, EngineType.Rotor, 35000, 2.5)};

            CarDealer carDealer = new CarDealer(cars);


            Func<Car, double> averagePrice = x => x.Price;
            Func<Car, double> averageEngineСapacity = x => x.EngineСapacity;
            Predicate<Car> isAudi = x => x.Brand == Brand.Audi;
            Predicate<Car> isPriceMore30k = x => x.Price > 30000;
            Func<Car, double> maxValuePrice = x => x.Price;
            Func<Car, double> maxValueEngineСapacity = x => x.EngineСapacity;

            Console.WriteLine(carDealer.GetAverage(averagePrice));
            Console.WriteLine(carDealer.GetAverage(averageEngineСapacity));
            Console.WriteLine(carDealer.GetCount(isAudi));
            Console.WriteLine(carDealer.GetCount(isPriceMore30k));
            Console.WriteLine(carDealer.GetMaxValue(maxValuePrice));
            Console.WriteLine(carDealer.GetMaxValue(maxValueEngineСapacity));
        }
    }
}
