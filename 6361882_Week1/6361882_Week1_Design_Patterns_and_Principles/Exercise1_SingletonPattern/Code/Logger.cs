using System;

namespace SingletonPatternCodes
{
    public class Logger
    {
        private static Logger instance = null;

        private Logger()
        {
            Console.WriteLine("Logger object created.");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log message: " + message);
        }
    }
}
