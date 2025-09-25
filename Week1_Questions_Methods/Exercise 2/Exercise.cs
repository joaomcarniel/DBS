// See https://aka.ms/new-console-template for more information
using Exercise_2;

Console.WriteLine("Welcome to the calculator!");
Service MyService = new Service();
var operation = "";

while (operation != "5")
{
    Console.WriteLine("Choose one option:\n1 - Sum, 2 - Subtract, 3 - Multiply, 4 - Divide, 5 - LEAVE");
    operation = Console.ReadLine();
    if (operation == "5") break;
    Console.WriteLine("Enter first number:");
    var firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    var secondNumber = Convert.ToDouble(Console.ReadLine());
    switch (operation)
    {
        case "1":
            MyService.Sum(firstNumber, secondNumber);
            continue;
        case "2":
            MyService.Subtract(firstNumber, secondNumber);
            continue;
        case "3":
            MyService.Multiply(firstNumber, secondNumber);
            continue;
        case "4":
            MyService.Divide(firstNumber, secondNumber);
            continue;
    }
}

