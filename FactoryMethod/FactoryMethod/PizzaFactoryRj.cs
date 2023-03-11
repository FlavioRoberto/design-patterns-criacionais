using System;
namespace FactoryMethod.FactoryMethod
{
    public class PizzaFactoryRj : PizzaFactoryMethod
    {
        public override Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "M": return new PizzaMozzarellaRj();
                case "P": return new PizzaPepperoniRj();
                default: throw new ApplicationException("Pizza not found");
            }
        }
    }
}

