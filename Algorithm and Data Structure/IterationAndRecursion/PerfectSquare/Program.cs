// See https://aka.ms/new-console-template for more information
using PerfectSquare;

Console.WriteLine("Hello, World!");
Service MyService = new Service();
var num = 4;
Console.WriteLine($"Is the number {num} a perfect square? {MyService.IsPerfectSquareByIteration(num)}. By Iteration");
Console.WriteLine($"Is the number {num} a perfect square? {MyService.IsPerfectSquareByRecursion(num)}. By Recursion");