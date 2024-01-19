using GiudiciaryService.AbstractProduct.AbstractFood;
using PortailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.ProductBreackfast
{
    public class Beverage : IBrunch
    {
        public override async Task<string> OrderMeal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Beverage Save");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(10000);
            return "Beverage";



        }

    }
}
