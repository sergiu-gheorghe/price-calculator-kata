namespace PriceCalculatorKata
{
    public interface ITaxCalculator
    {
        Money Calculate(Product product, decimal flatRateTax);
    }
}
