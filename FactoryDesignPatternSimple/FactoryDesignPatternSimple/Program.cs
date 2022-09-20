// See https://aka.ms/new-console-template for more information

using FactoryDesignPatternSimple;

Console.WriteLine("Hello, World!");

FruitFactory fruitFactory = new FruitFactory();

fruitFactory.CreateFruit("Apple");
fruitFactory.CreateFruit("Banana");