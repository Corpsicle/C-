// See https://aka.ms/new-console-template for more information
// Pseudocode / Plan:
// - Implement a safe input function `ReadDouble(prompt)` that:
//   - Repeatedly prompts the user until a valid number is entered.
//   - Treats a null `Console.ReadLine()` (EOF / Ctrl+Z) as a graceful exit.
//   - Uses `double.TryParse` with `NumberStyles.Float | NumberStyles.AllowThousands` and `CultureInfo.CurrentCulture`.
//   - Prints an error message on parse failure and retries.
// - In main (top-level):
//   - Set `Console.Title`.
//   - Read two numbers with `ReadDouble`.
//   - Compute and display the sum using current culture formatting.
//   - Pause with `Console.ReadKey(intercept: true)` before exit.
//
// This keeps behavior similar to the original but avoids exceptions from invalid input
// and handles EOF gracefully.

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (input is null) // EOF (Ctrl+Z or input stream closed)
                {
                    Console.WriteLine();
                    Console.WriteLine("No input received. Exiting.");
                    Environment.Exit(1);
                }

                if (double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double value))
                    return value;

                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        Console.Title = "Conversion";

        double first = ReadDouble("Please enter a number: ");
        double second = ReadDouble("Now enter another number: ");

        double sum = first + second;

        Console.WriteLine($"Total = {sum}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(intercept: true);
    }
}