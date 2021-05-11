using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_Cars
{
    public class CarDealer
    {
        public delegate double Averager(List<Car> cars);

        List<Car> cars = new List<Car>();

        public CarDealer(List<Car> cars)
        {
            this.cars = cars;
        }

        public double GetAverage(Averager averager)
        {
            return averager(cars);
        }

        //public int GetCount()
        //{

        //}
    }
}
