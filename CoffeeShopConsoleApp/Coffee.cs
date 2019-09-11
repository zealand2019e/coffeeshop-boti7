using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        public int Discount {get; set;}

        public Coffee(int discount)
        {
            if (discount > 5)
            {
                throw new ArgumentException(String.Format("{0} is too big discount.", discount),
                    "discount");
            }

            this.Discount = discount;
        }

        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20 - this.Discount;
        }

        public abstract string Strength();
    }
}
