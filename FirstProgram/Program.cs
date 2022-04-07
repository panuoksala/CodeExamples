using System;

Console.WriteLine("Syötä kokonaisluku: ");
var userInput = Console.ReadLine();

if (int.TryParse(userInput, out int parsedNumber))
{
    var exponent = parsedNumber * parsedNumber;
    Console.WriteLine(exponent);

    if(exponent > 100)
    {
        Console.WriteLine("Sata");
    }

    if(exponent > 200)
    {
        Console.WriteLine("Kaksi sataa");
    }
}
else
{
    Console.WriteLine("Syötetty arvo ei ollut kokonaisluku.");
}