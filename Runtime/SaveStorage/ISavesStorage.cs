namespace SaveSystem
{
    public interface ISavesStorage
    {
        bool HasSaves();
        
        void DeleteAllSaves();

    }
}