using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _activityName;
    private int _durationInSeconds;
    private string _description;

    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _durationInSeconds = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _durationInSeconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_durationInSeconds} seconds of the {_activityName}.");
        ShowSpinner(3);
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public int GetDuration()
    {
        return _durationInSeconds;
    }
}