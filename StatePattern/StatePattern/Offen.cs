namespace StatePattern;

public class Offen : IZustand
{
    public IZustand Open()
    {
        return new Offen();
    }

    public IZustand Close()
    {
        return new Zu();
    }
}