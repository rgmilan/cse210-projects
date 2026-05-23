using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 2, 17);

        string fullScriptureText = "When ye are in the service of your fellow beings ye are only in the service of your God";

        Scripture scripture = new Scripture(reference, fullScriptureText);

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to end:");

            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words are now hidden.");
            Console.WriteLine("You have 1 last try to recite it from memory.");
            Console.WriteLine("Press enter to see the complete scripture one last time.");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Complete scripture:");
            Console.WriteLine($"{reference.GetDisplayText()} {fullScriptureText}");
        }
    }
}