using NUnit.Framework;
using SaveSystem.Paths;
using SaveSystem.Tests.Dummys;

namespace SaveSystem.Tests
{
    public sealed class PlayerPrefsStorageTest
    {
        private const int Id = 46;
        private const string Name = nameof(PlayerPrefsStorageTest);
        private ISaveStorage<DummySaveData> _storage;

        [SetUp]
        public void SetUp()
        {
            IPath savePath = new DummySavePath();
            _storage = new PlayerPrefsStorage<DummySaveData>(savePath);
        }

        [Test]
        public void SavesCorrectly()
        {
            new SaveStorageTest().SavesCorrectly(_storage, Name, Id);
        }
        
        [Test]
        public void ThrowsExceptions()
        {
            new SaveStorageTest().ThrowsExceptions(_storage);
        }
    }
}