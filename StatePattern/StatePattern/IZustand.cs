namespace StatePattern;

public interface IZustand
{
    public IZustand Open();
    public IZustand Close();
}