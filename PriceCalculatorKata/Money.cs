using System;

namespace PriceCalculatorKata
{
    public sealed class Money
    {
        public decimal Value { get; private set; }
        public string Currency { get; private set; }
        
        public static Money Dollars(decimal value) => new Money(value, "$");
        public static Money ToTwoDecimalPrecision(decimal value) => Dollars(decimal.Round(value, 2, MidpointRounding.AwayFromZero));

        private Money(decimal value, string currency)
        {
            Value = value;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"{Currency + Value }";
        }
    }
}
