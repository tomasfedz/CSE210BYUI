using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class Word
{
    public string Text { get; } // Stores the word text
    public bool IsHidden { get; private set; } // Boolean to track if the word is hidden

    public Word(string text)
    {
        Text = text;
        IsHidden = false; // Initially, the word is not hidden
    }

    public void Hide()
    {
        IsHidden = true; // Mark the word as hidden
    }

    // Override ToString to display hidden words as underscores
    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}