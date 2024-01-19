
using PortailService.AbstractFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortailService.Product.ProductBreackfast
{
    public class Juice : Breackfast
    {
        //public double _price = 1; 


        public override async Task<string> OrderMeal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Juice save");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(10000);

            return "Juice";

            

        }
        //public double Price(int number)
        //{
        //    double one = 1;
        //    double Total = one * number;
        //    return Total;
        //}
    }
}
