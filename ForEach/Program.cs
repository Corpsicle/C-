// See https://aka.ms/new-console-template for more information
Console.Title = "For Each";
string [] websites = new string [] {"Google", "Youtube", "Facebook", "Twitter", "Instagram"};
Console.WriteLine("Popular Websites...");
int rank = 1;
foreach (string site in websites)
{
    Console.WriteLine($"Position: {rank}.\t {site}");
    rank++;
}
Console.ReadKey();
