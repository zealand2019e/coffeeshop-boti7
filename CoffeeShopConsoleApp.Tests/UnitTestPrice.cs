using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass]
    public class UnitTestPrice
    {
        [TestMethod]
        public void TestPriceBlackCoffee20()
        {
            BlackCoffee blackCoffee = new BlackCoffee();

            int actualPrice = blackCoffee.price();

            Assert.AreEqual(20, actualPrice);
        }

        [TestMethod]
        public void TestPriceLatte40()
        {
            Latte latte = new Latte();

            int actualPrice = latte.price();

            Assert.AreEqual(40, actualPrice);
        }

        [TestMethod]
        public void TestPriceCortado25()
        {
            Cortado cortado = new Cortado();

            int actualPrice = cortado.price();

            Assert.AreEqual(25, actualPrice);
        }
    }
}
