// See https://aka.ms/new-console-template for more information
using Exercise_4;

Console.WriteLine("Hello, World!");
Service MyService = new Service();

int[] arrayNum = MyService.ArrayOfNumbers(4, 8);
List<int> primeNumbers = MyService.ArrayOfPrimeNumbers(4, 9);
Console.WriteLine("Array of Numbers");
foreach (var a in arrayNum) 
{
    Console.WriteLine($"{a}");
}
Console.WriteLine("Array of Prime Numbers");
foreach (var p in primeNumbers)
{
    Console.WriteLine($"{p}");
}