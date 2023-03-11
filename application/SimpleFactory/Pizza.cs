using System;
namespace factory.SimpleFactory
{
	public abstract class Pizza
	{
		public string Name { get; set; }

		protected Pizza(string name)
		{
			Name = name;
		}

		public virtual void Prepare()
		{
            Console.WriteLine($"Is Preparing Pizza of {Name}");
        }

        public virtual void Bake(int minutes)
		{
            Console.WriteLine($"Pizza of {Name} is baking for {minutes} minutes");
        }

        public virtual void Pack()
		{
            Console.WriteLine($"Is Packing Pizza of {Name}");
        }
    }
}

