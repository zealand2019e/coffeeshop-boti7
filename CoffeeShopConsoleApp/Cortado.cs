using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee, Milk
    {
        public Cortado(int discount) : base(discount) {}

        public Cortado() : base(0) {}

        public override int price()
        {
            return 25 - this.Discount;
        }
        
        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }
    }
}
