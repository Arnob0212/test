using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }
}