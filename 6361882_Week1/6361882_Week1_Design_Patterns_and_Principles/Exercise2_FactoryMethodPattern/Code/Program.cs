using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            Document word = wordFactory.CreateDocument();
            word.Open();

            DocumentFactory pdfFactory = new PdfFactory();
            Document pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelFactory();
            Document excel = excelFactory.CreateDocument();
            excel.Open();
        }
    }
}

