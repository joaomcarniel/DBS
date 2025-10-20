// See https://aka.ms/new-console-template for more information

using SumOfDigitsOfANumber;

Service MyService = new Service();
int number = 0;
Console.WriteLine($"The sum of the digits of number {number} is {MyService.SumOfDigitsByIteration(number)}. By Iteration");
Console.WriteLine($"The sum of the digits of number {number} is {MyService.SumOfDigitsByRecursion(number)}. By Recursion");
