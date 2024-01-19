using GiudiciaryService.AbstractProduct.AbstractFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Product.ProductBreackfast
{
    internal class Burger : IBrunch
    {
        public override async Task<string> OrderMeal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Burger save");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(10000);
 
            return "Burger";



        }

    }
}
