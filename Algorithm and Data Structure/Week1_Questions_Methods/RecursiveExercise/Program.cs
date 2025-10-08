// See https://aka.ms/new-console-template for more information
using RecursiveExercise;

Console.WriteLine("Hello, World!");


Service MyService = new Service();
var fac = 5;
var factorialByIteration = MyService.FactorialByIteration(fac);
var factorialByRecursion = MyService.FactorialByRecursion(fac);
var fibonacciByIteration = MyService.FibonacciByIteration(fac);
var fibonacciByRecursion = MyService.FibonacciByRecursion(fac);

Console.WriteLine($"Iteration: Factorial of {fac} is {factorialByIteration}");
Console.WriteLine($"Recursion: Factorial of {fac} is {factorialByRecursion}");
Console.WriteLine($"Iteration: Fibonacci of {fac} is {fibonacciByIteration}");
Console.WriteLine($"Recursion: Fibonacci of {fac} is {fibonacciByRecursion}");