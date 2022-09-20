namespace FactoryDesignPattern;

public class Piano : IInstrument
{

  

    public void Use()
    {
        Console.WriteLine($"Playing the piano .");
    }
}