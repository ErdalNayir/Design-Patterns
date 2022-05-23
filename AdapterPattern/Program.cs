// See https://aka.ms/new-console-template for more information
using AdapterPattern;

CustomOperation customOperation = new CustomOperation(new CustomMathOperationsAdapter());

int result = customOperation.Topla(5, 4);

Console.WriteLine(result);
