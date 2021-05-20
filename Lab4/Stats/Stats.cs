using System.Collections;

namespace Lab4.Stats
{
    public abstract class Stats
    {
        public string Name;

        public Stats(string name)
        {
            Name = name;
        }
        
        public abstract int GetViewCount();
        public abstract string ToJson();
    }
}