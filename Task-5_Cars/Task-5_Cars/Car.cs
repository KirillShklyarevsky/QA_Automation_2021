using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_Cars
{
    public class Car
    {
        public Brand Brand { get; }

        public string Model { get; }

        public BodyType BodyType { get; }

        public EngineType EngineType { get; }

        public double Price { get; }

        public double EngineСapacity { get; }

        public Car(Brand brand, string model, BodyType bodyType, EngineType engineType, double price, double engineCapacity)
        {
            if (price < 0 || engineCapacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Brand = brand;
            Model = model;
            BodyType = bodyType;
            Price = price;
            EngineСapacity = engineCapacity;
        }

    }
}