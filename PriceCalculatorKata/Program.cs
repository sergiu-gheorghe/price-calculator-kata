namespace PriceCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("The Little Prince", 12345, Money.Dollars(20.25m));

            PriceCalculator priceCalculator = new PriceCalculator(new TaxCalculator());
            priceCalculator.DisplayBasePriceAndPriceWithTax(product, 20);
            priceCalculator.DisplayBasePriceAndPriceWithTax(product, 21);
        }
    }
}
