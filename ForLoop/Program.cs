// See https://aka.ms/new-console-template for more information
Console.Title = "ForLoop";
for (int i = 1; i < 4; i++)
{
    Console.WriteLine( $"Loop Iteration {i}" );
    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine( $"\tInner Loop Iteration {j}" );
    }
}
Console.ReadKey();