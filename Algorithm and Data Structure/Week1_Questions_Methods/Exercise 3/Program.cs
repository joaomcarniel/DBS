// See https://aka.ms/new-console-template for more information
using Exercise_3;

Service MyService = new Service();
Console.WriteLine($"SumAllNumbers: {MyService.SumAllNumbers(4,9)}");
Console.WriteLine($"SumEvenNumbers: {MyService.SumEvenNumbers(4,9)}");
Console.WriteLine($"SumOddNumbers: {MyService.SumOddNumbers(4,9)}");