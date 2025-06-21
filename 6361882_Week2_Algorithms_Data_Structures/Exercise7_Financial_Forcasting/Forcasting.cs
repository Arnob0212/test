using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Forcasting
{
    public class Forecast
    {
        public double PredictUsingLinearRegression(int[] years, double[] values, int predictYear)
        {
            int n = years.Length;
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += years[i];
                sumY += values[i];
                sumXY += years[i] * values[i];
                sumX2 += years[i] * years[i];
            }

            double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double intercept = (sumY - slope * sumX) / n;

            return slope * predictYear + intercept;
        }
    }
}