using NUnit.Framework;
using SaveSystem.Paths;
using SaveSystem.Tests.Dummys;

namespace SaveSystem.Tests
{
    public sealed class XmlStorageTest
    {
        private ISaveStorage<DummySaveData> _storage;
        private const string Name = nameof(XmlStorageTest);
        private const int Id = 99;

        [SetUp]
        public void SetUp()
        {
            IPath savePath = new DummySavePath();
            _storage = new XmlStorage<DummySaveData>(savePath);
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