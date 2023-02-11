namespace SaveSystem
{
    public interface ICanDeleteSaveStorage
    {
        bool HasSave();

        void DeleteSave();
    }
}