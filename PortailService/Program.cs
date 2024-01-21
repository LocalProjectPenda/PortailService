
using PortailService.Abstract;
using PortailService.Concrete;
using PortailService.Mail;
using PortailService.Model;
using PortailService.Product.ProductBreackfast;
using PortailService.ProductBreackfast;
using PortailService.Service;
using System;
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

            FactoryTranslate factoryTranslate = new TranslationStore();

            //User penda = new User() { Name = "penda", mail = "example@yop.com", address = "Siena", phone = "26564782" };
            //Juice juice = new Juice();
            //Cake cake = new Cake();
            //Coffe cafe = new Coffe();
            //Cappuccino cappuccino = new Cappuccino();
            //Burger burger = new Burger();
            //Nuggets nuggets = new Nuggets();
            //Chips chips = new Chips();
            //Beverage beverage = new Beverage();


            Console.WriteLine("Your Name:");
            User user1 = new User("", "");
            user1.Name = Console.ReadLine();
            Console.WriteLine("Your Email:");
            user1.mail = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"-------------------------------");


            DeliveryChoice deliyChoice = new DeliveryChoice();

            FactoryFood factoryFoods = deliyChoice.Choice();

            //if(factoryFoods == new MacDonald() )
            //{
           
    
           // }

            //FactoryFood factoryFoods = new MacDonald();
            //FactoryFood factoryFood = new Starbucks();


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



           


            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - FODD");
            Console.WriteLine("\t2 - TRANSLATE");
            
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string date = DateTime.Now.ToString("HH:mm");
                Console.WriteLine($"{date} --> FOOD PROVIDER NAME:  {factoryFoods.GetType().Name}--------");

                Console.ResetColor();
                Console.WriteLine($"-------------------------------");
                await Task.Delay(3000);

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

                Console.WriteLine($" Select FORMAT");

                Console.WriteLine("\t1 - PDF");
                Console.WriteLine("\t2 - WORD");
                Console.WriteLine("\t3 - HTML");
          
                int choice2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select language");

                string langue = Console.ReadLine();
                


                if (choice2 == 1)
                {
                    var orderTranslate= factoryTranslate.CreateGenerator("pdf");
                    Console.WriteLine($"ORDER:: PENDING for {user1.Name.ToUpper()} PENDING......");
                    await orderTranslate.GenerateTranslate(langue);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" the pdf in {langue} for {user1.Name.ToUpper()} is ready");
                   
                    Console.ResetColor();
                    Console.WriteLine($"-------------------------------");

                }
                else if (choice2 == 2)
                {
                    var orderTranslate = factoryTranslate.CreateGenerator("word");
                    Console.WriteLine($"ORDER:: PENDING for {user1.Name.ToUpper()} PENDING......");
                    await orderTranslate.GenerateTranslate(langue);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" the word in {langue} for {user1.Name.ToUpper()} is ready");

                    Console.ResetColor();
                    Console.WriteLine($"-------------------------------");

                }
                else if (choice2 == 3)
                {
                    var orderTranslate = factoryTranslate.CreateGenerator("html");
                    Console.WriteLine($"ORDER:: PENDING for {user1.Name.ToUpper()} PENDING......");
                    await orderTranslate.GenerateTranslate(langue);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" the html in {langue} for {user1.Name.ToUpper()} is ready");

                    Console.ResetColor();
                    Console.WriteLine($"-------------------------------");
                }
            }
              
            EmailService email = new EmailService();
                   
               MailData notification = new MailData();
            notification.ToEmail = user1.mail;
            notification.Subject = "state food Deliver";
            notification.Body = "your order has been delivered. Thank you for choossing our services";
                  
              await  email.SendEmailAsync(notification);

            Console.WriteLine($"Check the delivery notification on your email");


            Console.ReadLine();
            }
    }
}