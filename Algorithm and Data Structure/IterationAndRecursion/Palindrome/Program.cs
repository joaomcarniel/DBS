// See https://aka.ms/new-console-template for more information
using Palindrome;

Console.WriteLine("Hello, World!");

Service MyService = new Service();
var word = "civic";
Console.WriteLine($"The word {word} is Palindrome? " +
    $"{MyService.IsPalindromeByIteration(word)}. Made By Iteration");
Console.WriteLine($"The word {word} is Palindrome? " +
    $"{MyService.IsPalindromeByRecursion(word, 0)}. Made By Recursion");