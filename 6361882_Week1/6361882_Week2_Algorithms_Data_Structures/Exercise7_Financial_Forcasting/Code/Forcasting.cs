using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Forcasting
{
    public class Forecast
    {
        public double GetFutureValue(double value, double rate, int year)
        {
            if (year == 0)
            {
                return value;
            }

            double newValue = value + (value * rate);
            return GetFutureValue(newValue, rate, year - 1);
        }
    }
}