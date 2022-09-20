namespace VW_Uebung;

public class PorscheFactory : ICarFactory
{
    public ICar Build(string model)
    {
        return new Porsche(model);
    }
}