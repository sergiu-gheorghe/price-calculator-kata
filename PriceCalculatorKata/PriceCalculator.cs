using System;

namespace PriceCalculatorKata
{
    public class PriceCalculator
    {
        private ITaxCalculator _taxCalculator;

        public PriceCalculator(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public void DisplayBasePriceAndPriceWithTax(Product product, decimal flatRateTax)
        {
            Console.WriteLine($"Product price reported as { product.Price } before tax and { _taxCalculator.Calculate(product, flatRateTax)  } after { flatRateTax }% tax");
        }
    }
}