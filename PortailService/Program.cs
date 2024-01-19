
using PortailService.Abstract;
using PortailService.Concrete;
using PortailService.Model;
using PortailService.Product.ProductBreackfast;
using PortailService.ProductBreackfast;
using PortailService.Service;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortailService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppFood food = new AppFood();

            //User penda = new User() { Name = "penda", mail = "example@yop.com", address = "Siena", phone = "26564782" };
            Juice juice = new Juice();
            Cake cake = new Cake();
            Coffe cafe = new Coffe();
            Cappuccino cappuccino = new Cappuccino();
            Burger burger = new Burger();
            Nuggets nuggets = new Nuggets();
            Chips chips = new Chips();
            Beverage beverage = new Beverage();

            FactoryFood factoryFoods = new MacDonald();
            FactoryFood factoryFood = new Starbucks();


            //List<Task<string>> Results= new List<Task<string>>();
            //Task<string> jus = juice.OrderMeal(); 
            //Task<string> cap = cappuccino.OrderMeal(); 
            //Task<string> cup = cake.OrderMeal(); 
            //Task<string> cofe = cafe.OrderMeal(); 

            //Results.Add(jus);
            //Results.Add(cap);
            //Results.Add(cup);
            //Results.Add(cofe);

            //Console.WriteLine($"Sending Order {penda.Name.ToUpper()}...");
            //await food.Order(Results, penda);

            //List<Task<string>> Result = new List<Task<string>>();
            //Task<string> juss = juice.OrderMeal(); //Promise
            //Task<string> capp = cappuccino.OrderMeal(); //Promise

            //Result.Add(juss);
            //Result.Add(capp);
            //User anta = new User() { Name = "anta", mail = "example@yop.com", address = "Siena", phone = "26564782" };
            //Console.WriteLine($"Sending Order {anta.Name.ToUpper()}...");
            //await food.Order(Result, anta);


            //Console.ResetColor();
            //Console.ReadLine();



            Console.WriteLine("Your name:");
            User user1 = new User();
            user1.Name = Console.ReadLine();

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - FODD");
            Console.WriteLine("\t2 - TRANSLATE");
            
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {

                Console.WriteLine("Select Menu ");

                Console.WriteLine("\t1 - BREACKFAST");
                Console.WriteLine("\t2 - LUNCH");
                Console.WriteLine("\t2 - DINNER");
                
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    List<Task<string>> Res = new List<Task<string>>();

                    do
                    {
                        Console.WriteLine(" CHOICE LIST BREAKFAST");
                        Console.WriteLine("\t1 - COFFE");
                        Console.WriteLine("\t2 - CAPPUCCINO");
                        Console.WriteLine("\t3 - CAKE");
                        Console.WriteLine("\t4 - JUICE");
                        int menus = Convert.ToInt32(Console.ReadLine());
                        if (menus == 1)
                        {
                            //Res.Add(cafe.OrderMeal()); 
                            var orderBreackfast = factoryFoods.CreateBoxBreackfast(1);

                           Res.Add( orderBreackfast.OrderMeal());
                        }
                        else if (menus == 2)
                        {// Res.Add(cappuccino.OrderMeal());
                            var orderBreackfast = factoryFoods.CreateBoxBreackfast(2);

                            Res.Add(orderBreackfast.OrderMeal());
                        }
                        else if (menus == 3) 
                        { //Res.Add(cake.OrderMeal());

                            var orderBreackfast = factoryFoods.CreateBoxBreackfast(3);

                            Res.Add(orderBreackfast.OrderMeal());
                        }
                        else if (menus == 4)
                        { //Res.Add(juice.OrderMeal());
                            var orderBreackfast = factoryFoods.CreateBoxBreackfast(4);

                            Res.Add(orderBreackfast.OrderMeal());
                        }
                        Console.WriteLine(" y- to continue ou n to finish");

                    } while (Console.ReadLine() != "n");


                    Console.WriteLine($"Sending Order {user1.Name.ToUpper()}...");

                    await food.Order(Res, user1);
                }
                if (menu == 2)
                {
                    List<Task<string>> Res = new List<Task<string>>();

                    do
                    {
                        Console.WriteLine(" CHOICE LIST LUNCH");
                        Console.WriteLine("\t1 - BURGER");
                        Console.WriteLine("\t2 - NUGGET");
                        Console.WriteLine("\t3 - CHIPS");
                        Console.WriteLine("\t4 - BEVERAGE");
                        int menus = Convert.ToInt32(Console.ReadLine());
                        if (menus == 1) 
                        {
                            var orderLunch = factoryFoods.CreateBoxBreackfast(1);
                            Res.Add(orderLunch.OrderMeal());
                        }
                        else if (menus == 2)
                        {
                            var orderLunch = factoryFoods.CreateBoxBreackfast(2);
                            Res.Add(orderLunch.OrderMeal());
                        }
                        else if (menus == 3)
                        {
                            var orderLunch = factoryFoods.CreateBoxBreackfast(3);
                            Res.Add(orderLunch.OrderMeal());
                        }
                        else if (menus == 4)
                        {
                            var orderLunch = factoryFoods.CreateBoxBreackfast(4);
                            Res.Add(orderLunch.OrderMeal());
                        }
                        Console.WriteLine(" y- to continue ou n to finish");

                    } while (Console.ReadLine() != "n");
                    Console.WriteLine($"Sending Order {user1.Name.ToUpper()}...");

                    await food.Order(Res, user1);
                }

            }
            else if (choice == 2) {

                Console.WriteLine($" Select LANGUAGE");

                Console.WriteLine("\tM - MUSIC");
                Console.WriteLine("\tC - PROFILE");
                Console.WriteLine("\tA - ARTIST");
                Console.WriteLine("\tD - ALBUM");
                Console.WriteLine("\tP - PLAYLIST");
                Console.WriteLine("\tR - RADIO");
                Console.WriteLine("\tZ - SEARCH");
                Console.WriteLine("\tL - PLAYER");
                int choice2 = Convert.ToInt32(Console.ReadLine());
            }
              
                   
               
                  
            }
    }
}