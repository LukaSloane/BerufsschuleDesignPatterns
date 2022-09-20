namespace AdapterPattern;

public class FrenchSpeakingPerson : IPerson
{
    public void Antworten()
    {
        Console.WriteLine("Je suis tres bien");
    }

    public void Fragen()
    {
        Console.WriteLine("Comment allez-vous?");
    }
}