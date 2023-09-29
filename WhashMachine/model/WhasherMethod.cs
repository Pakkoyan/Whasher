namespace WhashMachine.model;

public partial class Whasher
{
    public static void AddWhasher(string name, float capacity)
    {
        brands.Add(name, new Whasher(name,capacity));
    }
    
    public void CottonWhash(float capacity)
    {
        if (capacity > this.capacity)
        {
            throw new Exception("слишком много шмоток в барабане");
        }

        temperature = 30;
        rpm = "weak";
        Console.WriteLine("ТУЦ ТУЦ ТУЦ ТУЦ БРЫНЬ БРЫНЬ БРЫНЬ *ЗВУКИ СТИРАЛКИ*");
        miliSecond = 30000;
        Thread.Sleep(miliSecond);
    }
    
    public void QuickWash(float capacity)
    {
        if (capacity > this.capacity)
        {
            throw new Exception("Слишком много вещей в барабане");
        }

        temperature = 40;
        rpm = "medium";
        Console.WriteLine("БЫСТРАЯ СТИРКА! *ЗВУКИ СТИРАЛКИ*");
        miliSecond = 15000;
        Thread.Sleep(miliSecond);
    }

    public void SportWash(float capacity)
    {
        if (capacity > this.capacity)
        {
            throw new Exception("Слишком много спортивной одежды в барабане");
        }

        temperature = 50;
        rpm = "strong";
        Console.WriteLine("СТИРКА ДЛЯ СПОРТИВНОЙ ОДЕЖДЫ! *ЗВУКИ СТИРАЛКИ*");
        miliSecond = 40000;
        Thread.Sleep(miliSecond);
    }

    
}