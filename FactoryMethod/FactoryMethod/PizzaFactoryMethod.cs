using System;
namespace FactoryMethod.FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        protected abstract Dictionary<string, Pizza> Pizzas { get; }

        public Pizza CreatePizza(string name)
        {
            try
            {
                return Pizzas[name];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("Pizza not found");
            }
        }

        public Pizza Make(string name)
        {
            Pizza pizza;
            pizza = CreatePizza(name);
            return pizza;
        }
    }
}

