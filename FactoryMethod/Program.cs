using System;
using FactoryMethod.FactoryMethod;

namespace factory.FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select locale (S)ão Paulo or (R)io de Janeiro");
            var locale = Console.ReadLine()?.ToUpper() ?? string.Empty;

            Console.WriteLine("Select your pizza (P)epperoni or (M)ozzarella");
            var selectedPizza = Console.ReadLine()?.ToUpper() ?? string.Empty;

            try
            {
                var selectedLocale = PizzaSimpleFactory.CreatePizzary(locale);
                var pizza = selectedLocale.CreatePizza(selectedPizza);
                var result = pizza.Prepare();
                Console.WriteLine(result);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}

