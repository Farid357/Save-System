using System;
using System.IO;
using UnityEngine;

namespace SaveSystem.Paths
{
    public sealed class Path : IPath
    {
        public static readonly string SavesFolder = Application.persistentDataPath + "Game Saves";

        public Path(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (!Directory.Exists(SavesFolder))
            {
                Directory.CreateDirectory(SavesFolder);
            }

            Name = System.IO.Path.Combine(Application.persistentDataPath, SavesFolder, name);
        }

        public string Name { get; }
    }
}