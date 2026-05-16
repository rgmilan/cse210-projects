using System;
using System.Collections.Generic;

public class Prompt
{
    public string _prompt = "";

    public List<string> _listPrompt = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_listPrompt.Count);

        return _listPrompt[index];
    }
}