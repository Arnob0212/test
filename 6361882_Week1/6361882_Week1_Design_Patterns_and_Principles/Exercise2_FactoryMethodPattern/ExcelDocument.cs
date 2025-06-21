using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public class ExcelDocument : Document
    {
        public void Open()
        {
            Console.WriteLine("Excel document is opened.");
        }
    }
}