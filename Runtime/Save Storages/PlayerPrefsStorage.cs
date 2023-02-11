using System;
using SaveSystem.Paths;
using UnityEngine;

namespace SaveSystem
{
    public sealed class PlayerPrefsStorage<TStoreValue> : ISaveStorage<TStoreValue>
    {
        private readonly string _pathName;

        public PlayerPrefsStorage(IPath path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            _pathName = path.Name;
        }
        
        public bool HasSave() => PlayerPrefs.HasKey(_pathName);

        public TStoreValue Load()
        {
            if (HasSave() == false)
                throw new HasNotSaveException(nameof(TStoreValue), _pathName);

            var loadJson = PlayerPrefs.GetString(_pathName);
            return JsonUtility.FromJson<TStoreValue>(loadJson);
        }

        public void Save(TStoreValue value)
        {
            var saveJson = JsonUtility.ToJson(value);
            PlayerPrefs.SetString(_pathName, saveJson);
            PlayerPrefs.Save();
        }

        public void DeleteSave()
        {
            if (HasSave() == false)
                throw new CannotDeleteSaveException(nameof(TStoreValue), _pathName);

            PlayerPrefs.DeleteKey(_pathName);
        }
    }
}