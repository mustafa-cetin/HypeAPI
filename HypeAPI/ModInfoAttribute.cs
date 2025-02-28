using System;

namespace HypeAPI
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ModInfoAttribute : Attribute
    {
        public string Name { get; }
        public string Version { get; }
        public ModInfoAttribute(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }
}
