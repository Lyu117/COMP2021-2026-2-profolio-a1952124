try
{
    Person person = new Person("Casey", "Smith", 20);

    Console.WriteLine($"Full name: {person.FullName()}");
    Console.WriteLine($"Age: {person.Age}");
    Console.WriteLine($"Is adult: {person.IsAdult()}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}