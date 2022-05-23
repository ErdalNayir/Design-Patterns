// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.Console;
using AbstractFactoryPattern.Factories;

TerminalOperation customOperation = new TerminalOperation(new HalkBankasiFactory());
Console.WriteLine(customOperation.GetHundredLiras("para çek"));
