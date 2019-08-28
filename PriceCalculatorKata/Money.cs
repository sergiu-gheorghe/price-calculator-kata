using System;

namespace PriceCalculatorKata
{
    public sealed class Money : IEquatable<Money>
    {
        public decimal Value { get; private set; }
        public string Currency { get; private set; }
        
        public static Money Dollars(decimal value) => new Money(value);
        public static Money ToTwoDecimalPrecision(decimal value) => new Money(decimal.Round(value, 2, MidpointRounding.AwayFromZero));

        private Money(decimal value, string currency = "$")
        {
            Value = value;
            Currency = currency;
        }

        //public static Money operator *(Money money, decimal amount) => new Money(money.Value * amount);
        //public static Money operator /(Money money, decimal amount) => new Money(money.Value / amount);
        //public static Money operator +(Money money, decimal amount) => new Money(money.Value + amount);

        public override string ToString() => $"{Currency + Value }";
        public override bool Equals(object obj) => Equals(obj as Money);
        public override int GetHashCode() => Value.GetHashCode() ^ Currency.GetHashCode();

        public bool Equals(Money other) => 
            other != null &&
            this.Value == other.Value &&
            this.Currency == other.Currency;
    }
}
