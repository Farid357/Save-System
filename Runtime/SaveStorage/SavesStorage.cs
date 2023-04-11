using System;
using System.IO;
using Path = SaveSystem.Paths.Path;

namespace SaveSystem
{
    public sealed class SavesStorage : ISavesStorage
    {
        private readonly string _savesFolderPath;

        public SavesStorage(string savesFolderPath)
        {
            _savesFolderPath = savesFolderPath ?? throw new ArgumentNullException(nameof(savesFolderPath));
        }

        public SavesStorage() : this(Path.SavesFolder)
        {
        }

        public bool HasSaves() => Directory.Exists(_savesFolderPath);

        public void DeleteAllSaves()
        {
            if (HasSaves() == false)
                throw new InvalidOperationException($"SaveStorages can't delete saves, because doesn't contain them!");
            
            Directory.Delete(_savesFolderPath, true);
        }
    }
}