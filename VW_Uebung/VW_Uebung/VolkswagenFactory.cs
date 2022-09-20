namespace VW_Uebung;

public class VolkswagenFactory : ICarFactory
{
    public ICar Build(string model)
    {
        return new Volkswagen(model);
    }
}