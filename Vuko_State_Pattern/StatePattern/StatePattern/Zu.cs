namespace StatePattern;

public class Zu : IZustand
{
    public IZustand Open()
    {
        return new Offen();
    }

    public IZustand Close()
    {
        return new Verschlossen();
    }
}