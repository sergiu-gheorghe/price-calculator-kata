using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriceCalculatorKata.Tests
{
    [TestClass]
    public class TaxCalculatorTests
    {
        [TestMethod]
        public void ApplyTax()
        {
            // Arrange
            Product product = new Product("The Little Prince", 12345, Money.Dollars(20.25m));
            ITaxCalculator calculator = new TaxCalculator();

            // Act
            var priceAfterTax20 = calculator.Calculate(product, 20);
            var priceAfterTax21 = calculator.Calculate(product, 21);

            // Assert
            Assert.AreEqual(Money.Dollars(20.25m), product.Price);
            Assert.AreEqual(Money.Dollars(24.30m), priceAfterTax20);
            Assert.AreEqual(Money.Dollars(24.50m), priceAfterTax21);
        }
    }
}
