using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoffeeShopConsoleApp;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass]
    public class UnitTestDiscount
    {
        [TestMethod]
        public void TestDiscountBlackCoffee()
        {
            BlackCoffee blackCoffee = new BlackCoffee(3);

            int actualPrice = blackCoffee.price();

            Assert.AreEqual(17, actualPrice);
        }

        [TestMethod]
        public void TestDiscountLatte()
        {
            Latte latte = new Latte(3);

            int actualPrice = latte.price();

            Assert.AreEqual(37, actualPrice);
        }

        [TestMethod]
        public void TestDiscountCortado()
        {
            Cortado cortado = new Cortado(3);

            int actualPrice = cortado.price();

            Assert.AreEqual(22, actualPrice);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Too big discount")]
        public void TestTooMuchDiscountCortado()
        {
            Cortado cortado = new Cortado(30);
        }
    }
}
