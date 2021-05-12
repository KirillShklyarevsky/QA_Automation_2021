using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_Cars
{
    public static class Helpers
    {
        public static double GetMaxValue(this CarDealer carDealer, Func<Car, double> maxField)
        {
            double maxValue = maxField(carDealer.Сars[0]);

            foreach (Car car in carDealer.Сars)
            {
                if (maxField(car) > maxValue)
                {
                    maxValue = maxField(car);
                }
            }

            return maxValue;
        }
    }
}
