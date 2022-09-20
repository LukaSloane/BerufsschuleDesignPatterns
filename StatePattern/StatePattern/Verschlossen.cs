namespace StatePattern;

public class Verschlossen : IZustand
{
    public IZustand Open()
    {
        return new Zu();
    }

    public IZustand Close()
    {
        return new Verschlossen();
    }
}