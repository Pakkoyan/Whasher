namespace WhashMachine.model;

public partial class Whasher
{
    private string name;
    private int temperature;
    private int miliSecond;
    private string rpm;
    private float capacity;
    private static Dictionary<string, Whasher> brands;

    static Whasher()
    {
        brands = new Dictionary<string, Whasher>
        {
            {"Bosch MP-1000", new Whasher("Bosch MP-1000", 5.0f)},
            {"AquaPulse 3000", new Whasher("AquaPulse 3000", 6.5f)},
            {"TurboClean Max", new Whasher("TurboClean Max", 7.0f)},
            {"SpinMaster Pro", new Whasher("SpinMaster Pro", 5.5f)},
            {"HygieneWash Elite", new Whasher("HygieneWash Elite", 8.0f)},
            {"EcoWasher Plus", new Whasher("EcoWasher Plus", 4.5f)},
            {"QuietStorm Ultra", new Whasher("QuietStorm Ultra", 6.0f)},
            {"RapidWash GT", new Whasher("RapidWash GT", 7.5f)},
            {"FreshWave X", new Whasher("FreshWave X", 6.2f)},
            {"CleanSpa Series 5", new Whasher("CleanSpa Series 5", 5.8f)},
            {"ZenithWash Zen", new Whasher("ZenithWash Zen", 9.0f)}
        };
    }

    private Whasher(string name, float capacity)
    {
        this.name = name;
        this.capacity = capacity;
    }

    public Whasher()
    {
        Console.WriteLine("Выбирите стиральную машинку из уже представленых:");

        foreach (var whasher in brands.Values)
        {
            Console.WriteLine("Название - {0}, Обьем - {1}", whasher.name, whasher.capacity);
        }
        Console.WriteLine("Впишите полное имя стиральной машинки которая вам понравилась ");

        Whasher newWhasher = new Whasher(Console.ReadLine());
    }

    public Whasher(string name)
    {
        if (!brands.ContainsKey(name))
        {
            throw new Exception("Именни данной стиральной машинки нету в списке");
        }
        
        this.name = brands[name].name;
        this.capacity = brands[name].capacity;
    }
    
    
    
    
}