// See https://aka.ms/new-console-template for more information
using LeastCommonMultiple;

var numA = 13;
var numB = 19;
Service MyService = new Service();
Console.WriteLine($"The LCM of {numA} and {numB} is {MyService.LCMByIteration(numA, numB)}. By Iteration");
Console.WriteLine($"The LCM of {numA} and {numB} is {MyService.LCMByIteration(numA, numB)}. By Recursion");