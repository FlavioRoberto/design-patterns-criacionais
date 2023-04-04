using System;
namespace Prototype.Prototype
{
	public class Soldier : ICloneable
	{
		public Gun Gun { get; set; }
		public string Name { get; private set; }

		public Soldier(Soldier soldier)
		{
			this.Name = soldier.Name;
			this.Gun = soldier.Gun;
		}

        public Soldier(string gun, string name)
        {
            Gun = new Gun(gun);
            Name = name;
        }

        public string ToString()
        {
            return $"Name: {Name}, Gun: {Gun.Name}";
        }

        public object Clone()
        {
            var soldier = new Soldier((Soldier)this.MemberwiseClone());
            soldier.Gun = (Gun)this.Gun.Clone();
            return soldier;
        }
    }
}

