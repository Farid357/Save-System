using NUnit.Framework;
using SaveSystem.Paths;
using SaveSystem.Tests.Dummys;

namespace SaveSystem.Tests
{
    public sealed class BinaryStorageTest
    {
        private const string Name = nameof(BinaryStorageTest);
        private const int Id = 10;
        private ISaveStorage<DummySaveData> _storage;

        [SetUp]
        public void SetUp()
        {
            IPath savePath = new DummySavePath();
            _storage = new BinaryStorage<DummySaveData>(savePath);
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
