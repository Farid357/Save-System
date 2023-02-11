using System;

namespace SaveSystem.Tests.Dummys
{
    [Serializable]
    public class DummySaveData
    {
        public string Name;
        public int Id;
        
        public DummySaveData(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public DummySaveData()
        {
            
        }
    }
}