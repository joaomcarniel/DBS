// See https://aka.ms/new-console-template for more information
using Polymorphism;

Employee e1 = new Employee("Joao", 1500m);
Employee se1 = new SalesEmployee("Marcos", 1500m, 1500m);
Console.WriteLine($"Method of Base Class: {e1.CalculatePay()}");
Console.WriteLine($"Method of Child Class: {se1.CalculatePay()}");

