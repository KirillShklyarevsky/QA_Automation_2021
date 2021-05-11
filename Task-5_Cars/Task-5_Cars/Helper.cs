using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_Cars
{
    public static class Helper
    {
        public static double CountAverageEngineСapacity(List<Car> cars)
        {
            double sum = 0;

            foreach (Car car in cars)
            {
                sum += car.EngineСapacity;
            }
            return sum / cars.Count;
        }
        public static double CountAveragePrice(List<Car> cars)
        {
            double sum = 0;

            foreach (Car car in cars)
            {
                sum += car.Price;
            }
            return sum / cars.Count;
        }
    }
}
