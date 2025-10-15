// See https://aka.ms/new-console-template for more information
using ReverseString;

Console.WriteLine("Hello, World!");
Service MyService = new Service();
var word = "Amazonas";

Console.WriteLine($"The reverse of word {word} is {MyService.ReverseStringByIteration(word)}. By Iteration");
Console.WriteLine($"The reverse of word {word} is {MyService.ReverseStringByRecursion(word, 0)}. By Recursion");
