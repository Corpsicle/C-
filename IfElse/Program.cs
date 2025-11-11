using System;
using System.Globalization;

// See https://aka.ms/new-console-template for more information
Console.Title = "IfElse";

double number = ReadDouble("Please enter a number: ");
char letter = ReadLetter("Thanks, now enter a letter: ");

if (number >= 6)
{
    Console.WriteLine("\nNumber exceeds 5.");
    if (char.ToUpperInvariant(letter) == 'C')
    {
        Console.WriteLine("Letter is C");
    }
}
else
{
    Console.WriteLine("\nNumber is 5 or less.");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey(intercept: true);

// -- Helper functions --

static double ReadDouble(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (input is null) // Ctrl+Z or input stream closed
        {
            Console.WriteLine("No input received. Exiting.");
            Environment.Exit(1);
        }

        input = input.Trim();
        if (double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double value))
            return value;

        Console.WriteLine("Invalid number. Please try again (use your locale's format).");
    }
}

static char ReadLetter(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (input is null)
        {
            Console.WriteLine("No input received. Exiting.");
            Environment.Exit(1);
        }

        input = input.Trim();
        if (input.Length > 0)
            return input[0];

        Console.WriteLine("Please enter at least one character.");
    }
}

