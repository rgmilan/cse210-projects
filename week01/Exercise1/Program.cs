using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user's first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get user's last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display full name in the format "Last Name, First Name Last Name"
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}