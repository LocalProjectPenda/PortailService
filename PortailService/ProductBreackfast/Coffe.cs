using PortailService.AbstractFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Product.ProductBreackfast
{
    internal class Coffe : Breackfast
    {
        public override async Task<string> OrderMeal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Coffee save");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(15000);
            
            return "Coffe";





        }
    }
}
