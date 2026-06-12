using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private int _totalScore;
    private List<Goal> _goal;

    public GoalManager()
    {
        _goal = new List<Goal>();
        _totalScore = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoal();
            }
            else if (choice == 3)
            {
                SaveGoal();
            }
            else if (choice == 4)
            {
                LoadGoal();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                AutoSaveGoal();
                Console.WriteLine();
                Console.WriteLine("Goals automatically saved to autosave.txt");
            }

            if (choice != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void ListGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goal[i].GetDetails()}");
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goal[i].GoalName()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goal.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goal.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goal.Add(new ChecklistGoal(
                name,
                description,
                points,
                targetCount,
                bonusPoints
            ));
        }

        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        if (_goal.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("The goals are:");

        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        int pointsEarned = _goal[goalNumber - 1].RecordsEvent();

        _totalScore += pointsEarned;

        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_totalScore} points.");
    }

    public void SaveGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (Goal goal in _goal)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goal.Clear();

        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] mainParts = lines[i].Split(':');
            string goalType = mainParts[0];
            string[] details = mainParts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                _goal.Add(new SimpleGoal(
                    details[0],
                    details[1],
                    int.Parse(details[2]),
                    bool.Parse(details[3])
                ));
            }
            else if (goalType == "EternalGoal")
            {
                _goal.Add(new EternalGoal(
                    details[0],
                    details[1],
                    int.Parse(details[2])
                ));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goal.Add(new ChecklistGoal(
                    details[0],
                    details[1],
                    int.Parse(details[2]),
                    int.Parse(details[3]),
                    int.Parse(details[4]),
                    int.Parse(details[5])
                ));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void AutoSaveGoal()
    {
        string filename = "autosave.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (Goal goal in _goal)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
}