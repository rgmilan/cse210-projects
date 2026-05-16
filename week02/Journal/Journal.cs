using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Diary> _listDiaries = new List<Diary>();

    public void Display()
    {
        if (_listDiaries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (Diary diary in _listDiaries)
            {
                diary.Display();
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Diary diary in _listDiaries)
            {
                outputFile.WriteLine($"{diary._dateEntry}|{diary._prompt}|{diary._diaryEntry}");
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        _listDiaries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Diary diary = new Diary();

            diary._dateEntry = DateTime.Parse(parts[0]);
            diary._prompt = parts[1];
            diary._diaryEntry = parts[2];

            _listDiaries.Add(diary);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}