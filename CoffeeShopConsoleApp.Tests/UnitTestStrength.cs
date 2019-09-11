using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass]
    public class UnitTestStrength
    {
        [TestMethod]
        public void TestStrengthBlackCoffee()
        {
            BlackCoffee blackCoffee = new BlackCoffee();

            string actualStrength = blackCoffee.Strength();

            Assert.AreEqual("Strong", actualStrength);
        }

        [TestMethod]
        public void TestStrengthLatte()
        {
            Latte latte = new Latte();

            string actualStrength = latte.Strength();

            Assert.AreEqual("Weak", actualStrength);
        }

        [TestMethod]
        public void TestStrengthCortado()
        {
            Cortado cortado = new Cortado();

            string actualStrength = cortado.Strength();

            Assert.AreEqual("Medium", actualStrength);
        }
    }
}
