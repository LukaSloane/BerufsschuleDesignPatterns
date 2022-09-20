// See https://aka.ms/new-console-template for more information

using VW_Uebung;

Console.WriteLine("Hello, World!");

ICarFactory carFactory = new VolkswagenFactory();
ICar car = carFactory.Build("5er Golf");
car.Drive();
Console.WriteLine();
carFactory = new PorscheFactory();
car = carFactory.Build("Chayenne");
car.Drive();