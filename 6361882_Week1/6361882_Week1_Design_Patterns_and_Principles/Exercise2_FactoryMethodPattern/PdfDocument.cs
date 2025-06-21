using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public class PdfDocument : Document
    {
        public void Open()
        {
            Console.WriteLine("PDF document is opened.");
        }
    }
}