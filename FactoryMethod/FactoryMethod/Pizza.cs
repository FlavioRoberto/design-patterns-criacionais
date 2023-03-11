using System;
using System.Collections;
using System.Text;

namespace FactoryMethod.FactoryMethod
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Pasta { get; set; }
        protected string Sauce { get; set; }
        protected ArrayList Ingredients { get; set; }

        protected Pizza(string name, string pasta, string sauce)
        {
            Name = name;
            Pasta = pasta;
            Sauce = sauce;
            Ingredients = new ArrayList();
        }

        public string Prepare()
        {
            var sb = new StringBuilder();
            sb.Append("Preparing " + Name);
            sb.Append(Pasta + "\n");
            sb.Append(Sauce + "\n");
            sb.Append("Ingredients: \n");

            foreach (var ingredient in Ingredients)
            {
                sb.Append("\t" + ingredient + "\n");
            }

            sb.Append(Bake());
            sb.Append(Slice());
            sb.Append(Pack());

            return sb.ToString();
        }

        public string Bake()
        {
            return $"Baking {Name} \n";
        }

        public string Slice()
        {
            return $"Slicing {Name} \n";
        }

        public string Pack()
        {
            return $"Packing {Name} \n";
        }
    }
}

