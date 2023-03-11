using System;
namespace FactoryMethod.FactoryMethod
{
	public static class PizzaSimpleFactory
	{
		public static PizzaFactoryMethod CreatePizzary(string locale)
		{
			switch (locale)
			{
				case "R": return new PizzaFactoryRj();
				case "S": return new PizzaFactorySp();
				default: throw new ApplicationException("Pizary not found");
			}
		}
	}
}

