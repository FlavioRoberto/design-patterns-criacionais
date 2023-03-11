using System;
namespace FactoryMethod.FactoryMethod
{
	public abstract class PizzaFactoryMethod
	{
		public abstract Pizza CreatePizza(string name);

		public Pizza Make(string name)
		{
			Pizza pizza;
			pizza = CreatePizza(name);
			return pizza;
		}
	}
}

