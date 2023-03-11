using System;
using System.Collections;

namespace FactoryMethod.FactoryMethod
{
    public class PizzaMozzarellaSp : Pizza
    {
        public PizzaMozzarellaSp()
            : base("São Paulo`s Mozzarella Pizza",
                   "Special Paulist pasta",
                   "Tomato paulist sauce")
        {
            Ingredients.Add("Parmesean Cheese");
            Ingredients.Add("Green Olivies");
        }
    }
}

