using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    List<Word> wordsList = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        wordsList.AddRange(_words.OrderBy(x => random.Next()).Take(numberToHide));
        foreach (var word in wordsList)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + " : " + string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}
