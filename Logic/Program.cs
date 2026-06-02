Console.Title = "Logic";

bool yes = true, no = false;

Console.Write( "AND logic:");
Console.Write("\t(yes && yes): " + (yes && yes) );
Console.Write("\n\t\t(yes && no ): " + (yes && no) );
Console.Write("\n\t\t(no  && no ): " + (no && no) );
Console.Write("\n\nOR logic:");
Console.Write("\t(yes || yes): " + (yes || yes) );
Console.Write("\n\t\t(yes || no ): " + (yes || no) );
Console.Write("\n\t\t(no  || no ): " + (no || no) );
Console.Write("\n\nNOT logic:");
Console.Write("\tyes = " + yes );
Console.Write("\t!yes =  " + !yes );
Console.Write("\n\t\tno = " + no );
Console.Write("\t!no = " + (!no) );
Console.ReadKey();
