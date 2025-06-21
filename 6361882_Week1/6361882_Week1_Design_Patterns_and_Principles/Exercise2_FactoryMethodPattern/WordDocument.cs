using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public class WordDocument : Document
    {
        public void Open()
        {
            Console.WriteLine("Word document is opened.");
        }
    }
}