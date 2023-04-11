using NUnit.Framework;
using SaveSystem.Tests.Dummys;

namespace SaveSystem.Tests
{
    [TestFixture]
    public class SavesStorageTest
    {
        [Test]
        public void DeletesCorrectly()
        {
            ISaveStorage<int> storage = new BinaryStorage<int>(new DummySavePath());
            storage.Save(10);
            ISavesStorage savesStorage = new SavesStorage();
            Assert.That(savesStorage.HasSaves());
            savesStorage.DeleteAllSaves();
            Assert.That(!savesStorage.HasSaves());
            Assert.That(storage.HasSave() == false);
        }
    }
}