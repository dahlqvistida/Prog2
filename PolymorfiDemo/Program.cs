using System;
using System.Collections.Generic;

namespace PolymorfiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.FatContent = 1;
            milk.ProductNumber = 123;
            milk.StockStatus = 10;

            cart.Add(milk);

            Nocco nocco = new Nocco();
            nocco.Flavor = "Cola";
            nocco.ProductNumber = 258;
            nocco.StockStatus = 33;

            cart.Add(nocco);

            Coffee coffee = new Coffee();
            coffee.Roastyness = "Dark";
            coffee.ProductNumber = 987;
            coffee.StockStatus = 198;

            cart.Add(coffee);

            foreach (var product in cart)
            {
                //För att skriva ut något som inte finns i metod
                if (product.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)product).FatContent); 
                }
                else if (product.GetType() == typeof(Coffee))
                {
                    Console.WriteLine(((Coffee)product).Roastyness); 
                }
                else if (product.GetType() == typeof(Nocco))
                {
                    Console.WriteLine(((Nocco)product).Flavor); 
                }
                

            }

        }
    }
}
