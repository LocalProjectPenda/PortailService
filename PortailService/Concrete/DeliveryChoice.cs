using PortailService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Concrete
{
    public class DeliveryChoice
    {
        public FactoryFood Choice() 
        {
           // MacDonald MacDo = new MacDonald();
            //Starbucks starbucks = new Starbucks();

            Random random = new Random();
            var provider = new List<string> { "MacDonalds", "Starbucks" };
            int index = random.Next(provider.Count);
            var prov = provider[index];
            provider.RemoveAt(index);
            if (prov == "MacDonalds")
            {
                return new MacDonald();

            }
            else
            {
                return new Starbucks();
            }
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //string date = DateTime.Now.ToString("HH:mm");
            //Console.WriteLine($"{date} --> ORDER SEND TO {prov}--------");
        }
    }
}
