namespace PriceCalculatorKata
{
    public class Product
    {
        public string Name { get; private set; }
        public long UPC { get; private set; }
        public Money Price { get; private set; }

        public Product(string name, long upc, Money price)
        {
            Name = name;
            UPC = upc;
            Price = price;
        }
    }
}
