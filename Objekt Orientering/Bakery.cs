using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;

namespace Objekt_Orientering
{
    class Bakery
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to our bakery!");

            Console.WriteLine("");

            Console.WriteLine("Creat your costumer");
            Console.WriteLine("Write your name");

            //Creates costumer with a name
            Costumer person = new Costumer();
            person._name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Welcome " + person._name);

            Console.WriteLine("");

            Console.WriteLine("What do you want to buy today?");
            
            Console.WriteLine("(1) - Bread");
            Console.WriteLine("(2) - Cakes");
            Console.WriteLine("(3) - Nothing, im done");

            Console.WriteLine("");

            var options = 0;
            var breadOption = 0;
            var cakeOption = 0;

            ShoppingCart shoppingCart = new ShoppingCart();

            List<ShoppingCart> cart = new List<ShoppingCart>();

            //User has to decide what to buy, by writing an integer
            options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1:

                    Console.WriteLine("What kind of bread do you want to buy?");
                    Console.WriteLine("NOTE write the number of which one you want to buy");

                    Console.WriteLine(" ");

                    Console.WriteLine("(1) - CarrotBread");
                    Console.WriteLine("(2) - GreekBread");
                    Console.WriteLine("(3) - WahlnutsBread");
                    Console.WriteLine("(4) - DanishBread");

                    breadOption = Convert.ToInt32(Console.ReadLine());

                    switch (breadOption)
                    {

                        case 1:
                            
                            cart.Add("CarrotBread");

                            break;
                        case 2:

                            cart.Add("GreekBread");

                            break;
                        case 3:

                            cart.Add("WahlnutsBread");

                            break;
                        case 4:

                            cart.Add("DanishBread");

                            break;

                        default:
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("What kind of cake do you want to buy?");
                    Console.WriteLine("NOTE write the number of which one you want to buy");

                    Console.WriteLine(" ");
                    Console.WriteLine("(1) - BirthDay Cake");
                    Console.WriteLine("(2) - Marzipan Cake");
                    Console.WriteLine("(3) - Redvelvet Muffin");
                    Console.WriteLine("(4) - Chocolate cake");

                    cakeOption = Convert.ToInt32(Console.ReadLine());

                    switch (cakeOption)
                    {
                        case 1:

                            cart.Add("BirthDay Cake");

                            Console.WriteLine("You added a " + shoppingCart._product);

                            break;
                        case 2:

                            cart.Add("MarzipanCake");

                            break;
                        case 3:

                            cart.Add("Redvelvet Muffin");

                            break;
                        case 4:

                            cart.Add("Chocolate Cake");

                            break;

                        default:
                            break;
                    }
                    break;

            }

            cart.ToArray();

            foreach (var shopCart in cart)
            {
                Console.WriteLine("You bought these things: ");
                Console.WriteLine(shopCart);
            }

        }
    }
}
