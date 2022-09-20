// See https://aka.ms/new-console-template for more information


using System.Diagnostics.CodeAnalysis;
using StatePattern;

Console.WriteLine("Hello, World!");

Door door = new Door(new Offen());
door.Close();
door.Close();