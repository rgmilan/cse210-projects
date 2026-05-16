using System;

public class Diary
{
    public string _diaryEntry = "";
    public string _prompt = "";
    public DateTime _dateEntry;

    public string GetPrompt()
    {
        return _prompt;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_dateEntry.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_diaryEntry}");
        Console.WriteLine();
    }

    public void SaveEntry()
    {
    }
}