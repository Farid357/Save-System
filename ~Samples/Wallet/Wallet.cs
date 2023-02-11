using System;
using SaveSystem;

namespace Samples
{
    public sealed class Wallet : IWallet
    {
        private readonly ISaveStorage<Money> _storage;

        public Wallet(ISaveStorage<Money> storage)
        {
            _storage = storage ?? throw new ArgumentNullException(nameof(storage));
            Money = _storage.HasSave() ? _storage.Load() : new Money(10);
        }
        

        public Money Money { get; private set; }


        public void Put(Money money)
        {
            Money += money;
            _storage.Save(Money);
        }

        public void Take(Money money)
        {
            Money -= money;
            _storage.Save(Money);
        }
    }
}