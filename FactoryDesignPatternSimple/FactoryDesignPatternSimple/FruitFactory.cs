namespace FactoryDesignPatternSimple;

public class FruitFactory
{
    public IFruit CreateFruit(string name)
    {
        if (name == "Apple")
        {
            Console.WriteLine($"{name} wurde hergestellt.");
            return new Apple();
            
        }

        if (name == "Banana")
        {
            Console.WriteLine($"{name} wurde hergestellt.");
            return new Banana();
        }

        throw new Exception();
    } 
}