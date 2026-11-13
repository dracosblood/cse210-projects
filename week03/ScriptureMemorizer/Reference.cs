// Create for Darwin J Tovar.
//for CSE210 in BYU Pathway worldwide.

using System;
using System.Collections.Concurrent;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //the function for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; // It is initialized to 0 to indicate that there is no second verse.
    }

    //function for a range of verses (example: Proverbs 3:5-6)
    public Reference(string book, int chapter, int starVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = starVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_endVerse == 0) 
        {
            return $"{_book} {_chapter} {_verse}";
        }
        else
        {
            return $"{_book} {_chapter} {_verse} {_endVerse}";
        }
    }

}
