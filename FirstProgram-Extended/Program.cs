using System;
using System.IO;

string userInput = "";
do
{
    Console.WriteLine("Syötä desimaaliluku: ");
    userInput = Console.ReadLine();

    if (decimal.TryParse(userInput, out decimal parsedNumber))
    {
        var exponent = parsedNumber * parsedNumber;
        // Use @ to escape characters in path.
        File.AppendAllText(@"C:\temp\numbers.txt", exponent.ToString() + Environment.NewLine);

        if (exponent > 100)
        {
            Console.WriteLine("Sata");
        }

        if (exponent > 200)
        {
            Console.WriteLine("Kaksi sataa");
        }
    }
    else
    {
        Console.WriteLine("Syötetty arvo ei ollut kokonaisluku.");
    }
} while (!string.Equals(userInput, "0"));