using System;

namespace Samples
{
    [Serializable]
    public sealed class Money
    {
        public int Amount;
        
        public Money(int amount)
        {
            Amount = amount;
        }

        public Money()
        {
            
        }

        
        public static Money operator -(Money moneyA, Money moneyB)
        {
            return new Money(moneyA.Amount - moneyB.Amount);
        }
        
        public static Money operator +(Money moneyA, Money moneyB)
        {
            return new Money(moneyA.Amount + moneyB.Amount);
        }

        public static implicit operator int(Money money) => money.Amount;
        
    }
}