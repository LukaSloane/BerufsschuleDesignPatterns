namespace AdapterPattern;

public class EnglischSpeakingPerson : IPerson
{
    public void Antworten()
    {
        Console.WriteLine("I am Fine.");
    }

    public void Fragen()
    {
        Console.WriteLine("How are you?");
    }
}