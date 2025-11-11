// See https://aka.ms/new-console-template for more information
// Improved Assign sample - clearer, safer, formatted output
Console.Title = "Assign - Improved";

void ApplyAndShow(string title, ref int a, int b, Func<int, int, int> op, string opLabel)
{
    int before = a;
    int result = op(a, b);
    a = result;
    Console.WriteLine($"{title}:\t {before} {opLabel} {b} => a = {a}");
}

int a = 8;
int b = 4;

Console.WriteLine("Initial values:");
Console.WriteLine($"\t a = {a}");
Console.WriteLine($"\t b = {b}\n");

ApplyAndShow("Add and Assign\t", ref a, b, (x, y) => x + y, "+=");
ApplyAndShow("Subtract and Assign", ref a, b,  (x, y) => x - y,    "-=");
ApplyAndShow("Multiply and Assign", ref a, b,  (x, y) => x * y,    "*=");
ApplyAndShow("Divide and Assign", ref a, b,    (x, y) => y == 0 ? x : x / y, "/=");
ApplyAndShow("Modulus and Assign", ref a, b,   (x, y) => y == 0 ? 0 : x % y, "%=");

Console.WriteLine("\nDone. Press any key to exit...");
Console.ReadKey(true);
