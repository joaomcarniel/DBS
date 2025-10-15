// See https://aka.ms/new-console-template for more information
using Exercise1;

Console.WriteLine("Hello, World!");


Service MyService = new Service();
Console.WriteLine($"Iteration: {MyService.SumOfRangeByIteration(10, 19)}");
Console.WriteLine($"Recursion: {MyService.SumOfRangeByRecursion(10, 19)}");