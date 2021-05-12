using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_Cars
{
    public class CarDealer
    {
        public List<Car> Сars { get; set; }

        public CarDealer(List<Car> cars)
        {
            Сars = cars;
        }

        public double GetAverage(Func<Car, double> averager)
        {
            double sum = 0;

            foreach (Car car in Сars)
            {
                sum += averager(car);
            }
            return sum / Сars.Count;
        }

        public int GetCount(Predicate<Car> isField)
        {
            int count = 0;

            foreach (Car car in Сars)
            {
                if (isField(car))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
