// See https://aka.ms/new-console-template for more information
Console.Title = "Assign";

int a = 8;
int b = 4;

Console.Write("Assign Values: ");
Console.Write("\ta = " + a);
Console.WriteLine("\tb = " + b);

Console.Write("\nAdd and Assign: ");
Console.Write($"\ta += b ({a} += {b})\t");
a += b;
Console.Write($"a = {a}");

Console.Write("\n\nSubtract and Assign: ");
Console.Write($"\ta -= b ({a} -= {b})\t");
a -= b;
Console.Write($"a = {a}");

Console.Write("\n\nMultiply and Assign: ");
Console.Write($"\ta *= b ({a} *= {b})\t");
a *= b;
Console.Write($"a = {a}");

Console.Write("\n\nDivide and Assign: ");
Console.Write($"\ta /= b ({a} /= {b})\t");
a /= b;
Console.Write($"a = {a}");

Console.Write("\n\nModulus and Assign: ");
Console.Write($"\ta %= b ({a} %= {b})\t");
a %= b;
Console.WriteLine($"a = {a}");

Console.ReadKey();
