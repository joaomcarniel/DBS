// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("How many lines of asterisk would you like to generate?");
var lines = int.Parse(Console.ReadLine());
PrintRightAngleTriangle(lines);
PrintRightAngleTriangleNumber(lines);
PrintRightAngleTriangleNumberSequence(lines);
RightAngleIncreasedByOne(lines);
PyramidIncreasedByOne(lines);
PyramidWithAsterisk(lines);
TermsOfHarmonicSeries(lines);


static void PrintRightAngleTriangle(int lines)
{
    for(int i =0; i < lines; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();    
    }
    Console.WriteLine();
}

static void PrintRightAngleTriangleNumber(int num)
{
    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void PrintRightAngleTriangleNumberSequence(int num)
{
    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void RightAngleIncreasedByOne(int num)
{
    int k = 1;
    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{k} ");
            k++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void PyramidIncreasedByOne(int num)
{
    int avg = (num / 2) + 1;
    for(int i = 1; i <= num; i++)
    {
        for (int numSpaces = 1; numSpaces <= num-i; numSpaces++)
        {
            Console.Write(" ");
        }

        for (int number = 1; number <= i; number++)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void PyramidWithAsterisk(int num)
{
    int avg = (num / 2) + 1;
    for (int i = 1; i <= num; i++)
    {
        for (int numSpaces = 1; numSpaces <= num - i; numSpaces++)
        {
            Console.Write(" ");
        }

        for (int number = 1; number <= i; number++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void TermsOfHarmonicSeries(int term)
{
    double result = 0;

    for(int i = 1; i <= term; i++)
    {
        Console.Write($"1/{i} + ");
        result += 1.0 / i; 
    }
    Console.WriteLine($"The result of Harmonic Series is: {result}");
    Console.WriteLine();
}