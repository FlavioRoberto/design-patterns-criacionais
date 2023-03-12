using System;
namespace FactoryMethod.FactoryMethod
{
    public class PizzaFactoryRj : PizzaFactoryMethod
    {
        protected override Dictionary<string, Pizza> Pizzas => new Dictionary<string, Pizza>
        {
            {"M", new PizzaMozzarellaRj()},
            {"P", new PizzaPepperoniRj()}
        };
    }
}

