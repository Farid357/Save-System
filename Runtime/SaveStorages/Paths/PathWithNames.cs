using UnityEngine;

namespace SaveSystem.Paths
{
    public sealed class PathWithNames<TStorageUser, TStoreValue> : IPath
    {
        public PathWithNames()
        {
            Name = Application.persistentDataPath + nameof(TStorageUser) + nameof(TStoreValue);
        }
        
        public string Name { get; }
    }
}