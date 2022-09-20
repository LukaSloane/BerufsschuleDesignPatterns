// See https://aka.ms/new-console-template for more information



// TODO HIER SIND DIE ANTWORTEN ZU DEN AUFGABEN:

// Aufgabe 1 & 2: Simple Factory
// Aufgabe 3 & 4: Factory Method


using FactoryDesignPattern;

Console.WriteLine("Hello");

IInstrumentFactory gitarrenhersteller = new GuitarFactory();
IInstrumentFactory pianohersteller = new PianoFactory();

IInstrument gitarre = gitarrenhersteller.CreateInstrument();
IInstrument piano = pianohersteller.CreateInstrument();
gitarre.Use();
piano.Use();