// See https://aka.ms/new-console-template for more information
Console.Title = "Switch";

int num = 3;
string day;

switch( num )
{
    case 1 : day = "Monday"; break;
    case 2 : day = "Tuesday"; break;
    case 3 : day = "Wednesday"; break;
    case 4 : day = "Thursday"; break;
    case 5 : day = "Friday"; break;
    default : day = "Weekend Day"; break;
}

Console.WriteLine($"Day {num} : {day}");
Console.ReadKey();