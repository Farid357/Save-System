namespace SaveSystem
{
    public interface ISaveStorage<TStoreValue> : ICanDeleteSaveStorage
    {
        TStoreValue Load();

        void Save(TStoreValue value);
    }
}