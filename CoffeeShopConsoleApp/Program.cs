using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(0),
                new Cortado(10),
                new Latte(10)
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine("Price: " + coffee.price() + " Strength: " + coffee.Strength());
            }

            List<Milk> milkOrderList = new List<Milk>()
            {
                new Cortado(10),
                new Latte(10)
            };

            Console.WriteLine("");
            Console.WriteLine("Coffee with milk:");
            foreach (var coffee in milkOrderList)
            {
                Console.WriteLine("Milk: " + coffee.mlMilk() + " ml");
            }
        }
    }
}
