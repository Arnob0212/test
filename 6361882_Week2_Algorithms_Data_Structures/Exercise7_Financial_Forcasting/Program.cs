using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Forcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] years = { 1, 2, 3, 4, 5 };
            double[] values = { 900, 1200, 1500, 1800, 2100 };

            Console.WriteLine("Enter the year to predict :");
            int predictYear = Convert.ToInt32(Console.ReadLine());

            Forecast calc = new Forecast();
            double prediction = calc.PredictUsingLinearRegression(years, values, predictYear);

            Console.WriteLine("Predicted value for year " + predictYear + ": " + prediction);
        }
    }
}

