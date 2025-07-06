using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    public static class RetrieveData
    {
        public static async Task RunAsync()
        {
            using var context = new AppDbContext();

            var products = await context.Products.ToListAsync();
            foreach (var p in products)
                Console.WriteLine($"{p.Name} - ₹{p.Price}");

            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"Found: {product?.Name}");

            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"Expensive: {expensive?.Name}");
        }
    }
}
