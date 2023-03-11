using System;
namespace factory.SimpleFactory
{
    public class Program
    {
        static void Main(string[] args)
        {

            Pizza pizza;
            Console.WriteLine("Select your pizza (P)epperoni or (M)ozzarella");
            var selectedPizza = Console.ReadLine()?.ToUpper() ?? string.Empty;
            try
            {
                pizza = PizzaFactory.Create(selectedPizza);
                pizza.Prepare();
                pizza.Bake(60);
                pizza.Pack();
                Console.WriteLine("Pizza delivered with success");
            }
            catch (ApplicationException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadLine();
        }
    }
}

