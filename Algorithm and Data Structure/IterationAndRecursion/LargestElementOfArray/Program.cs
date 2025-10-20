// See https://aka.ms/new-console-template for more information

using LargestElementOfArray;

Service MyService = new Service();
var arrayNum = new int[] { 4, 5, 8, 6 };

Console.WriteLine($"The largest element of array is " +
    $"{MyService.LargestElementOfArrayByIteration(arrayNum)}. By Iteration");
