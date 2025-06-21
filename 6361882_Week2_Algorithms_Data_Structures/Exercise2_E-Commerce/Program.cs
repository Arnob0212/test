using E_Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce

{
    class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[5];
        products[0] = new Product(1, "RDR2", "Action-Adventure");
        products[1] = new Product(2, "GTA 6", "Open World");
        products[2] = new Product(3, "Far Cry 5", "First-Person Shooter");
        products[3] = new Product(4, "Satisfactory", "Simulation");
        products[4] = new Product(5, "War Thunder", "Combat Flight Simulator");

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        Console.WriteLine("Enter product name to search:");
        string input = Console.ReadLine();

        Search search = new Search();

        int index1 = search.LinearSearch(products, input);
        int index2 = search.BinarySearch(products, input);

        Console.WriteLine();

        if (index1 != -1)
            Console.WriteLine("Linear Search: Found " + products[index1].ProductName + " at index " + index1);
        else
            Console.WriteLine("Linear Search: Not Found");

        if (index2 != -1)
            Console.WriteLine("Binary Search: Found " + products[index2].ProductName + " at index " + index2);
        else
            Console.WriteLine("Binary Search: Not Found");
    }
}
}
