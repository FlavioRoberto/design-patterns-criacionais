using System;
namespace FactoryMethod.FactoryMethod
{
	public class PizzaFactorySp : PizzaFactoryMethod
	{
        public override Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "M": return new PizzaMozzarellaSp();
                case "P": return new PizzaPepperoniSp();
                default: throw new ApplicationException("Pizza not found");
            }
        }
    }
}

