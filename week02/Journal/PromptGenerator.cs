using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What did you learn today?",
        "What did you do today?",
        "What are you grateful for today?",
        "What was the best part of your day?",
        "What challenges did you face today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}