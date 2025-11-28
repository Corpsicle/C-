// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

Console.Title = "Input";
Console.OutputEncoding = Encoding.UTF8;

string name = GetName(args);
Console.WriteLine();
Console.WriteLine($"Welcome, {name}!");
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey(true);

string GetName(string[] args)
{
    // Accept the first command-line argument as a name if provided
    if (args is { Length: > 0 })
    {
        var candidate = args[0]?.Trim();
        if (!string.IsNullOrEmpty(candidate))
            return candidate;
    }

    const int maxAttempts = 3;
    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        Console.Write("Please enter your name: ");
        string? input = Console.ReadLine()?.Trim();

        if (!string.IsNullOrEmpty(input))
            return input;

        Console.WriteLine($"Invalid input. {maxAttempts - attempt} attempt(s) remaining.");
    }

    // Graceful fallback
    return "Guest";
}
