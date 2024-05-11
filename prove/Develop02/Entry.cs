using System;

public class Entry
{

    public string _date;

    public string _promptText;

    public string _entryText;

    public Entry(string promptText, string entryText, string dateText)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = dateText;
    }



    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText}\n{_entryText}\n");
    }

}