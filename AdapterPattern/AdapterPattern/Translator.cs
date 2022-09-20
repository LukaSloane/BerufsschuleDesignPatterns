namespace AdapterPattern;

public class Translator
{
    IPerson fromPerson;
    IPerson toPerson;

    public Translator(IPerson fromPerson, IPerson toPerson)
    {
        this.fromPerson = fromPerson;
        this.toPerson = toPerson;
    }

    public void Antworten()
    {
        toPerson.Antworten();
        fromPerson.Antworten();
    }

    public void Fragen()
    {
        fromPerson.Fragen();
        toPerson.Fragen();
    }
}