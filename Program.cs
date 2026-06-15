Console.WriteLine("Hello, World!");

Console.WriteLine("Enter your name: ");

var name = Console.ReadLine();

Console.WriteLine("Enter your age: ");

var age = Console.ReadLine();

Console.WriteLine($"Hello, {name}. You are {age} years old.");


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Fizzbuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
