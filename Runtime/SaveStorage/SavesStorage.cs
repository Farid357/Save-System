using System;
using System.IO;
using Path = SaveSystem.Paths.Path;

namespace SaveSystem
{
    public sealed class SavesStorage : ISavesStorage
    {
        public bool HasSaves() => Directory.Exists(Path.SavesFolder);

        public void DeleteAllSaves()
        {
            if (HasSaves() == false)
                throw new InvalidOperationException($"SaveStorages can't delete saves, because doesn't contain them!");
            
            Directory.Delete(Path.SavesFolder, true);
        }
    }
}