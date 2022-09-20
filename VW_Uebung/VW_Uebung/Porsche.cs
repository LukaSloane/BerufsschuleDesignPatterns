namespace VW_Uebung;

public class Porsche : ICar
{
    private string model;

    public Porsche(string model)
    {
        this.model = model;
    }

    public void Drive()
    {
        Console.WriteLine($"Ein Porsche {model} fährt die Straße gen Sonnenuntergang entlang...");
    }
}