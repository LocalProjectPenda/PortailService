using PortailService.AbstractFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Product.ProductBreackfast
{
    public class Cake : Breackfast
    {
        public override async Task<string> OrderMeal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cake save");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(10000);            
            return "Cake";

            



        }
    }
}
