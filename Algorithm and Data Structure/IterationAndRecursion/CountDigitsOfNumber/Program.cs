// See https://aka.ms/new-console-template for more information
using CountDigitsOfNumber;

Service MyService = new Service();
var number = 6464535;

Console.WriteLine($"The number of digits on the number {number} is {MyService.CountDigitsByIteration(number)}. By Iteration");
Console.WriteLine($"The number of digits on the number {number} is {MyService.CountDigitsByRecursion(number)}. By Recursion");