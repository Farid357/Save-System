namespace SaveSystem
{
    public interface ISaveStorages
    {
        bool HasSaves();
        
        void Add(ICanDeleteSaveStorage storage);
        
        void DeleteAllSaves();

    }
}