using SaveSystem.Paths;

namespace SaveSystem.Tests.Dummys
{
    public sealed class DummySavePath : IPath
    {
        public string Name { get; } = $"{nameof(DummySaveData)}";
    }
}