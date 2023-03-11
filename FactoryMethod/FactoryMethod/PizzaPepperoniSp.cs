using System;
namespace FactoryMethod.FactoryMethod
{
	public class PizzaPepperoniSp : Pizza
	{
        public PizzaPepperoniSp()
           : base("São Paulo`s Pepperoni Pizza",
                  "Special Paulist pasta",
                  "Tomato paulist sauce")
        {
            Ingredients.Add("Parmesean Cheese");
            Ingredients.Add("Pepperoni slices");
        }
    }
}

