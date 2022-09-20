namespace FactoryDesignPattern;

public class GuitarFactory : IInstrumentFactory
{
    public IInstrument CreateInstrument()
    {
        Console.WriteLine("One Guitar was created.");
        return new Guitar();
    }
}