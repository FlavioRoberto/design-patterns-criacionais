using System;
namespace FactoryMethod.FactoryMethod
{
    public class PizzaFactorySp : PizzaFactoryMethod
    {
        protected override Dictionary<string, Pizza> Pizzas => new Dictionary<string, Pizza>
        {
            {"M", new PizzaMozzarellaSp()},
            {"P", new PizzaPepperoniSp()}
        };
    }
}

