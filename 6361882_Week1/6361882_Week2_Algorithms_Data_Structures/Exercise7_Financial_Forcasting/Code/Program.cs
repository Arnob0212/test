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
            Forecast f = new Forecast();

            Console.WriteLine("Enter current value:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter yearly growth rate (in %):");
            double rate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Enter number of years:");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = f.GetFutureValue(amount, rate, n);

            Console.WriteLine("Future value is: " + result);
        }
    }
}

