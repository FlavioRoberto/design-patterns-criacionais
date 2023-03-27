namespace AbstractFactory;
class Program
{
    static void Main(string[] args)
    {
        var custumerHonda = new Custumer(new HondaFactory());
        var custumerHyundai = new Custumer(new HyundaiFactory());

        Console.WriteLine($"Honda sedan details {custumerHonda.GetSedanDetails()}");
        Console.WriteLine($"Honda suv details {custumerHonda.GetSuvDetails()}");

        Console.WriteLine($"Hyundai sedan details {custumerHyundai.GetSedanDetails()}");
        Console.WriteLine($"Hyundai suv details {custumerHyundai.GetSuvDetails()}");
    }
}

