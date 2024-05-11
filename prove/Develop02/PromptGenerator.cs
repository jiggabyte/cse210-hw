using System;
using System.Collections.Generic;

public class PromptGenerator {

    List<string> _prompts = new List<string>();

    public PromptGenerator(List<string> data)
    {
        foreach(string listData in data)
        {
            _prompts.Add(listData);            
        }
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }

}