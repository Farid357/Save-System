using NUnit.Framework;
using SaveSystem.Tests.Dummys;

namespace SaveSystem.Tests
{
    public sealed class SaveStorageTest
    {
        public void SavesCorrectly(ISaveStorage<DummySaveData> storage, string name, int id)
        {
            if (storage.HasSave())
                storage.DeleteSave();
            
            storage.Save(new DummySaveData(id, name));
            DummySaveData loadedData = storage.Load();
            Assert.That(loadedData.Id == id && loadedData.Name == name);
        }
        
        public void ThrowsExceptions(ISaveStorage<DummySaveData> storage)
        {
            if (storage.HasSave())
                storage.DeleteSave();
            
            Assert.Throws<CannotDeleteSaveException>(() => storage.DeleteSave());
            Assert.Throws<HasNotSaveException>(() => storage.Load());
        }
    }
}