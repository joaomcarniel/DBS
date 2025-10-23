// See https://aka.ms/new-console-template for more information
using ProductOfNumbers;

Console.WriteLine("Hello, World!");
var array = new int[] { 2, 3, 7, 1 };

Service MyService = new Service();

Console.WriteLine($"Product of numbers is {MyService.ProductByIteration(array)}. By iteration");
Console.WriteLine($"Product of numbers is {MyService.ProductByRecursion(array)}. By iteration");

