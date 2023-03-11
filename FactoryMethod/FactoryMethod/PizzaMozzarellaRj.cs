using System;
namespace FactoryMethod.FactoryMethod
{
	public class PizzaMozzarellaRj : Pizza
	{
        public PizzaMozzarellaRj()
           : base("Rio de janeiro`s Mozzarella Pizza",
                  "Special carioca pasta",
                  "Tomato carioca sauce")
        {
            Ingredients.Add("Parmesean Cheese");
            Ingredients.Add("Green Olivies");
        }
    }
}

