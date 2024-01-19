
using PortailService.AbstractFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Product.ProductBreackfast
{
    public class Cappuccino : Breackfast
    {
        public override async Task<string> OrderMeal()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cappuccino save");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(15000);
            
            return "Cappuccino";


            //double one = 1;
            //double Total = one * howmany;
            //return "Cappuccino";
        }
        //public double Price(int number)
        //{
        //    double one = 1.5;
        //    double Total = one* number;
        //    return Total;
        //}
    }
}
