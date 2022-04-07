var listOfNumbers = new List<int> { 1, 5, 10, 20, 50 };

int biggestFound = FindBiggestNumberFromCollection(listOfNumbers);

Console.WriteLine(biggestFound);

listOfNumbers.Add(7);
listOfNumbers.Add(101);

biggestFound = FindBiggestNumberFromCollection(listOfNumbers);

Console.WriteLine(biggestFound);


static int FindBiggestNumberFromCollection(List<int> listOfNumbers)
{
    var biggestFound = -1;
    foreach (var number in listOfNumbers)
    {
        if (number > biggestFound)
        {
            biggestFound = number;
        }
    }

    return biggestFound;
}