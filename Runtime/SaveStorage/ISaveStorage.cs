namespace SaveSystem
{
    public interface ISaveStorage<TStoreValue>
    {
        bool HasSave();

        TStoreValue Load();

        void Save(TStoreValue value);
        
        void DeleteSave();
    }
}