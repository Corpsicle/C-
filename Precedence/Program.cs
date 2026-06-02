Console.Title = "Precendence";

int sum;

sum = 1 + 4 * 3;
Console.WriteLine("Default Order:\t\t" + sum);

sum = ( 1 + 4 ) * 3;
Console.WriteLine("Forced Order:\t\t" + sum);

sum = 7 - 4 + 2;
Console.WriteLine("\nDefault Direction:\t" + sum);

sum = 7 - (4 + 2);
Console.WriteLine("Forced Direction:\t" + sum);

Console.ReadKey();

