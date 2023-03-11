using System;
namespace factory.SimpleFactory
{
	public static class PizzaFactory
	{
		public static Pizza Create(string pizzaName)
		{
			Pizza? pizza = null;

			switch (pizzaName)
			{
				case "P": pizza = new PizzaPepperoni();break;
				case "M": pizza = new PizzaMozzarella();break;
				default: throw new ApplicationException($"Pizza of {pizzaName} not found");
			}

			return pizza;
		}
	}
}

