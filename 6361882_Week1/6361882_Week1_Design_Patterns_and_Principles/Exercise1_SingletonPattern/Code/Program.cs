using System;

namespace SingletonPatternCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the 1st log.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the 2nd log.");

            if (logger1 == logger2)
            {
                Console.WriteLine("Same logger used both time.");
            }
            else
            {
                Console.WriteLine("Different logger used.");
            }
        }
    }
}
