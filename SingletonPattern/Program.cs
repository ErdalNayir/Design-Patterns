// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Logger firstInstanceRequest = Logger.GetInstance();
Logger secondInstanceRequest = Logger.GetInstance();
Console.WriteLine(firstInstanceRequest == secondInstanceRequest) ;