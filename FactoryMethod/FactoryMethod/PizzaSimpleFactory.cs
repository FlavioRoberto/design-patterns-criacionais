using System;
namespace FactoryMethod.FactoryMethod
{
    public static class PizzaSimpleFactory
    {
        private static Dictionary<string, PizzaFactoryMethod> PizzasFactories = new Dictionary<string, PizzaFactoryMethod>
        {
            {"R", new PizzaFactoryRj() },
            {"S", new PizzaFactorySp() }
        };

        public static PizzaFactoryMethod CreatePizzary(string locale)
        {
            var pizzaFactory = PizzasFactories[locale];

            if (pizzaFactory == null)
                throw new ApplicationException("Pizary not found");

            return pizzaFactory;
        }
    }
}

