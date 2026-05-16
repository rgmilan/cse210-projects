using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();
        Menu menu = new Menu();

        int choice = 0;

        while (choice != 5)
        {
            menu.LoadMenu();

            Console.Write("Select an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Diary diary = new Diary();
                diary._prompt = randomPrompt;
                diary._diaryEntry = response;
                diary._dateEntry = DateTime.Now;

                journal._listDiaries.Add(diary);

                Console.WriteLine();
                Console.WriteLine("Journal entry added successfully.");
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.WriteLine();

                string[] files = Directory.GetFiles(".", "*.txt");

                Console.WriteLine("Available journal files:");

                if (files.Length == 0)
                {
                    Console.WriteLine("No journal files found.");
                }
                else
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }

                    Console.WriteLine();
                    Console.Write("Enter filename to load: ");

                    string filename = Console.ReadLine();

                    if (!filename.EndsWith(".txt"))
                    {
                        filename += ".txt";
                    }

                    journal.LoadFromFile(filename);
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine();

                string[] files = Directory.GetFiles(".", "*.txt");

                Console.WriteLine("Existing journal files:");

                if (files.Length == 0)
                {
                    Console.WriteLine("No journal files found.");
                }
                else
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }
                }

                Console.WriteLine();
                Console.Write("Enter filename to save: ");

                string filename = Console.ReadLine();

                if (!filename.EndsWith(".txt"))
                {
                    filename += ".txt";
                }

                journal.SaveToFile(filename);

                Console.WriteLine($"Journal saved on {DateTime.Now.ToShortDateString()}");
            }
            else if (choice == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid option.");
            }

            Console.WriteLine();
        }
    }
}