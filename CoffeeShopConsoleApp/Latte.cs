using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte : Coffee, Milk
    {
        public Latte(int discount) : base(discount) {}

        public Latte() : base(0) {}

        public override int price()
        {
            return 40 - this.Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }
}
