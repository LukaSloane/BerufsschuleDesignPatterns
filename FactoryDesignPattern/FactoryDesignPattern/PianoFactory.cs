namespace FactoryDesignPattern;

public class PianoFactory : IInstrumentFactory
{
    public IInstrument CreateInstrument()
    {
        Console.WriteLine("One Piano was created.");
        return new Piano();
    }
}