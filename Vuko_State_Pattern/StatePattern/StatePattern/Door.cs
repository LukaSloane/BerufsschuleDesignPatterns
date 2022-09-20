namespace StatePattern;

public class Door
{
    private IZustand currentState;

    public Door(IZustand currentState)
    {
        this.currentState = currentState;
    }

    public void Open()
    {
        currentState = currentState.Open();
    }

    public void Close()
    {
        currentState = currentState.Close();
    }
}