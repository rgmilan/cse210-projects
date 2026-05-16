using System;
using System.Collections.Generic;

public class Menu
{
    public string _menu = "";

    public List<string> _menuList = new List<string>()
    {
        "1. Write an entry to my journal",
        "2. Display the entry of my journal",
        "3. Load an entry from my journal",
        "4. Save an entry to my journal",
        "5. Quit"
    };

    public void LoadMenu()
    {
        Console.WriteLine("What do you want to do in your Journal today?");
        Console.WriteLine();

        foreach (string item in _menuList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}