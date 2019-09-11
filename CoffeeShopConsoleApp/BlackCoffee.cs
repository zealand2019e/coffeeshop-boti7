using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount) : base(discount) {}

        public BlackCoffee() : base(0) {}

        public override string Strength()
        {
            return "Strong";
        }
    }
}
