using System;
namespace Prototype.Prototype
{
	public class Gun : ICloneable
	{
        public string Name { get; private set; }

        public Gun(string name)
        {
            Name = name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

