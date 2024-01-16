using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // Ask user for thier name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the user's name in full
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}