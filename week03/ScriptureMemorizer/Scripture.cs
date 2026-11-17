using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();

        string[] words= text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()}\n{displayText}";
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        for (int i = 0; i < numberToHide; i++)
        {
            if (AllWordsHidden())
            {
                return;
            }
            
            int index = random.Next(0, _words.Count);
            
            while (_words[index].IsHidden())
            {
                index = random.Next(0, _words.Count);
            }
            _words[index].Hide();
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}