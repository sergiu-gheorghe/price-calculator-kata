using System;

namespace PriceCalculatorKata
{
    public class TaxCalculator : ITaxCalculator
    {
        public Money Calculate(Product product, decimal flatRateTax)
        {
            var result = product.Price.Value + (product.Price.Value * flatRateTax / 100);
            return Money.ToTwoDecimalPrecision(result);
        }
    }
}
