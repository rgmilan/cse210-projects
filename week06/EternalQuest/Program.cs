using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeded Requirements:
        // I added an autosave feature to the program. When the user chooses
        // the Quit option, the program automatically saves all goals and the
        // current score to autosave.txt before closing. This way, the user
        // won't lose progress if they forget to save manually.

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}