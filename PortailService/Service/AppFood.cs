using PortailService.Model;
using PortailService.Product.ProductBreackfast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Service
{
    public class AppFood
    {
        public async Task Order(List<Task<string>> tasks, User user)
        {

            List<Task<string>> Results = tasks;
            OrderClient order = new OrderClient();



            Random random = new Random();
            var provider = new List<string> { "MacDonalds", "Starbucks" };
            int index = random.Next(provider.Count);
            var prov = provider[index];
            provider.RemoveAt(index);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string date = DateTime.Now.ToString("HH:mm");
            Console.WriteLine($"{date} --> ORDER SEND TO {prov}--------");

            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(3000);


            order.FluidCheckups(Results, user);/// Runs Taks in  parallel [ Async noAwait]
           
            Console.ForegroundColor = ConsoleColor.Yellow;

            await Task.Run(async () =>
            {

                // Do a long task here while others tasks are running in parallel!  s
                Console.WriteLine($"INVOICE -  STARTED for {user.Name.ToUpper()}");
                await Task.Delay(new Random().Next(5000, 20000));
            });

            Console.WriteLine($"ORDER - FINISHED for {user.Name.ToUpper()}");


            Console.ResetColor();
            // WaitAllCheckupsAndDismiss(patient);
            Console.WriteLine($"-------------------------------");


        }
    }
}
