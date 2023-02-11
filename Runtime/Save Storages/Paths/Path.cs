using System;
using UnityEngine;

namespace SaveSystem.Paths
{
    public sealed class Path : IPath
    {
        public Path(string name)
        {
            if (name == null) 
                throw new ArgumentNullException(nameof(name));
            
            Name = Application.persistentDataPath + name;
        }

        public string Name { get; }
    }
}