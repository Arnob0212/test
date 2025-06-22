using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public class ExcelFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
