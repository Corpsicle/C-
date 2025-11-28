// Improved Arithmetic demo - clearer output, input validation, and safer division
using System.Globalization;

Console.Title = "Arithmetic - Improved";

// Get values (press Enter to use defaults)
double a = GetNumber("Enter first number (default 8): ", 8);
double b = GetNumber("Enter second number (default 4): ", 4);

PrintArithmetic(a, b);

// Demonstrate prefix/postfix using integer copies
DemonstrateIncrement((int)a, (int)b);

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

static double GetNumber(string prompt, double defaultValue)
{
    Console.Write(prompt);
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
        return defaultValue;

    // Accept culture-invariant number formats
    if (double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out double value))
        return value;

    // Try parse with current culture as a fallback
    if (double.TryParse(input, out value))
        return value;

    Console.WriteLine("Invalid input. Using default value: " + defaultValue);
    return defaultValue;
}

static void PrintArithmetic(double a, double b)
{
    Console.WriteLine();
    Console.WriteLine("{0,-20} {1}", "Operation", "Result");
    Console.WriteLine(new string('-', 32));
    Console.WriteLine("{0,-20} {1}", "Addition:", (a + b));
    Console.WriteLine("{0,-20} {1}", "Subtraction:", (a - b));
    Console.WriteLine("{0,-20} {1}", "Multiplication:", (a * b));

    if (b == 0)
        Console.WriteLine("{0,-20} {1}", "Division:", "Error (division by zero)");
    else
        Console.WriteLine("{0,-20} {1}", "Division:", (a / b));

    if (b == 0)
        Console.WriteLine("{0,-20} {1}", "Modulus:", "Error (modulus by zero)");
    else
        Console.WriteLine("{0,-20} {1}", "Modulus:", (a % b));
}

static void DemonstrateIncrement(int a, int b)
{
    Console.WriteLine();
    Console.WriteLine("Integer increment demonstrations (using integer copies):");
    Console.WriteLine();

    int copyA = a;
    Console.WriteLine($"Initial copyA: {copyA}");
    Console.WriteLine($"Postfix increment (copyA++): {copyA++}"); // prints old, then increments
    Console.WriteLine($"After postfix, copyA: {copyA}");

    int copyB = b;
    Console.WriteLine();
    Console.WriteLine($"Initial copyB: {copyB}");
    Console.WriteLine($"Prefix increment (++copyB): {++copyB}"); // increments, then prints
    Console.WriteLine($"After prefix, copyB: {copyB}");
}
