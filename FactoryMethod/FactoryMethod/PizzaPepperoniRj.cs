using System;
namespace FactoryMethod.FactoryMethod
{
    public class PizzaPepperoniRj : Pizza
    {
        public PizzaPepperoniRj()
           : base("Rio de janeiro`s Pepperoni Pizza",
                  "Special carioca pasta",
                  "Tomato carioca sauce")
        {
            Ingredients.Add("Pepperoni slices");
        }
    }
}

