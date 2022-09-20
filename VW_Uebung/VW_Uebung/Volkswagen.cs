namespace VW_Uebung;

public class Volkswagen : ICar
{
    private string model;

    public Volkswagen(string model)
    {
        this.model = model;
    }

    public void Drive()
    {
        Console.WriteLine($"Ein VW {model} fährt die Straße gen Sonnenuntergang entlang...");
    }
}