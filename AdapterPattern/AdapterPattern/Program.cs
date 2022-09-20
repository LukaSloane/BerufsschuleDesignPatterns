// See https://aka.ms/new-console-template for more information

using AdapterPattern;

Console.WriteLine("Hello, World!");

Translator translator = new Translator(new EnglischSpeakingPerson(), new FrenchSpeakingPerson());
translator.Fragen();
Console.WriteLine();
translator.Antworten();

Console.WriteLine("-----------------");
translator = new Translator(new FrenchSpeakingPerson(), new EnglischSpeakingPerson());
translator.Fragen();
Console.WriteLine();
translator.Antworten();