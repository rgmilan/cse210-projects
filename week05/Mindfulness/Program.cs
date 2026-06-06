using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeded Requirements:
        // I added an activity counter that tracks how many mindfulness
        // activities the user completes during the session.
        // The user can also view the counter anytime from the menu.

        int choice = 0;
        int sessionCount = 0;

        while (choice != 5)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. View activity counter");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                sessionCount++;
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                sessionCount++;
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                sessionCount++;
            }
            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activity Counter");
                Console.WriteLine();
                Console.WriteLine($"You have completed {sessionCount} activities this session.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
        }

        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program.");
        Console.WriteLine($"You completed {sessionCount} mindfulness activities this session.");
    }
}