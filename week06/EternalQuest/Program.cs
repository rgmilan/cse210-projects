using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeded Requirements:
        // Added an automatic save feature. Whenever the user exits the
        // program using the Quit option, all goals and the current score
        // are automatically saved to autosave.txt. This helps prevent
        // accidental data loss if the user forgets to manually save.

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}