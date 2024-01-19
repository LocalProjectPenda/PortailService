using PortailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Service
{
    internal class OrderClient
    {
        public async void FluidCheckups(List<Task<string>> tasks, User user)
        {
            Console.WriteLine($"ORDER:: PENDING for {user.Name.ToUpper()} PENDING......");

            List<string> product = new List<string>();

            while (tasks.Count > 0)
            {

                Console.Out.WriteLine($"Awaiting for any of the remaining order to complete  for {user.Name.ToUpper()}...");

                Task<string> finishedTask = await Task.WhenAny(tasks);
               

                string result = await finishedTask;

                if (result == "Juice")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    product.Add("Juice");
                    Console.ResetColor();
                    Console.WriteLine($"-------------------------------");
                }
                else if (result == "Cappuccino")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Cappuccino");
                    Console.WriteLine($"-------------------------------");
                }
                else if (result == "Cake")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Cake");
                    Console.WriteLine($"-------------------------------");
                }
                else if (result == "Coffe")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Coffe");
                    Console.WriteLine($"-------------------------------");
                } else if (result == "Burger")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Burger");
                    Console.WriteLine($"-------------------------------");
                } else if (result == "Nuggets")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Nuggets");
                    Console.WriteLine($"-------------------------------");
                } else if (result == "Chips")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Chips");
                    Console.WriteLine($"-------------------------------");
                } else if (result == "Beverage")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{result} for {user.Name.ToUpper()} is ready");
                    Console.ResetColor();
                    product.Add("Beverage");
                    Console.WriteLine($"-------------------------------");
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                //Console.WriteLine($"-------------------------------");
                Console.ResetColor();

                // Remove the completed task from the list
                tasks.Remove(finishedTask);
            }

            Console.WriteLine($"ORDER READY for {user.Name.ToUpper()}");
           // char euroSymbol = '\u20AC';
            double Total = 0;

            foreach (var item in product)
            {
                if (item == "Juice")
                {
                   
                    Console.WriteLine($"{item} ---> 1.5$");
                    Total += 1.5;
                   
                   // Console.WriteLine($"-------------------------------");
                }
                else if (item == "Cappuccino")
                {
                    Console.WriteLine($"{item} ---> 2$");
                    Total += 2;
                   // Console.WriteLine($"-------------------------------");
                }
                else if (item == "Cake")
                {
                    Console.WriteLine($"{item} ---> 2.5$");
                    Total += 2.5;
                   // Console.WriteLine($"-------------------------------");
                }
                else if (item == "Coffe")
                {
                    Console.WriteLine($"{item} ---> 1.5$");
                    Total += 1.5;
                   // Console.WriteLine($"-------------------------------");
                }
                else if (item == "Burger")
                {
                    Console.WriteLine($"{item} ---> 5$");
                    Total += 5;
                    //Console.WriteLine($"-------------------------------");
                }
                else if (item == "Nuggets")
                {
                    Console.WriteLine($"{item} ---> 8$");
                    Total += 8;
                    //Console.WriteLine($"-------------------------------");
                }
                else if (item == "Chips")
                {
                    Console.WriteLine($"{item} ---> 2.5$");
                    Total += 2.5;
                   // Console.WriteLine($"-------------------------------");
                }
                else if (item == "Beverage")
                {
                    Console.WriteLine($"{item} ---> 1$");
                    Total += 1;
                   // Console.WriteLine($"-------------------------------");
                }

            }

            Console.WriteLine($"-------------------------------");

            Console.WriteLine($" BASKET : {Total} $");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{user.Name.ToUpper()} ORDER BEING DELIVERED!");
            Console.ResetColor();

            Console.WriteLine($"-------------------------------");


        }

    }
}
