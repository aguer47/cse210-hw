using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _rand = new Random(); 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(part => new Word(part))
                     .ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); 
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }

    public bool AllWordsHidden() => _words.All(w => w.IsHidden());
}
