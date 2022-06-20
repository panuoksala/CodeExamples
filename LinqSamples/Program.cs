// LINQ Samples
var customers = new List<Customer>
{
    new Customer { Name = "John", Address = "Elk street 127", Age = 30},
    new Customer { Name = "Doe", Address = "Doe street 15", Age = 42},
    new Customer { Name = "Mary", Address = "Mary Elk road 8", Age = 59},
    new Customer { Name = "Emil", Address = "Downtown Abbey 99", Age = 20},
    new Customer { Name = "Barry", Address = "Remote worker street 1", Age = 18},
};

var oldestCustomerStreet = customers.MaxBy(customer => customer.Age).Address;
Console.WriteLine($"Oldest customer address is: {oldestCustomerStreet}");

var everyCustomerAgeThatHasFourLetterName = customers.Where(customer => customer.Name.Length == 4)
                                                     .Select(customer => customer.Age);

// This is wrong and returns the name of collection class!
//Console.WriteLine($"Ages are: {everyCustomerAgeThatHasFourLetterName}");
Console.WriteLine($"Ages are: {string.Join(",", everyCustomerAgeThatHasFourLetterName)}");

Console.WriteLine($"Ages sorted: {string.Join(",", everyCustomerAgeThatHasFourLetterName.OrderBy(age => age))}");

var allCustomersWhosNameStartsWithM = customers.Where(customer => customer.Name.StartsWith("M")).AsQueryable();
var allCustomersWhosNameStartsWithB = customers.Where(customer => customer.Name.StartsWith("B")).AsQueryable();

var combinedNames = allCustomersWhosNameStartsWithB.Union(allCustomersWhosNameStartsWithM).ToList();

Console.WriteLine($"Combined names: {string.Join(",", combinedNames.Select(customer => customer.Name))}");

class Customer
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int Age { get; set; }
}