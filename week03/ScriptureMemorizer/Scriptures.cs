// Create for Darwin J Tovar.
//for CSE210 in BYU Pathway worldwide.
// this program content:
// 1. receive the reference and the full text of the verse
// Split the text by spaces and create a Word object for each word.
// 2. look for all the words that are not yet hidden
// 3. a word is selected at random and then hidden
 //4. Check if all the words are already hidden

using System;
using System.Collections.Generic;

public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    
    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        
        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

   
    public void HideRandomWords(int numberToHide)
    {
    
    List<Word> visibleWords = new List<Word>();
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    
    Random random = new Random();
    int wordsToSelect = Math.Min(numberToHide, visibleWords.Count);

    for (int i = 0; i < wordsToSelect; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        //remove them from the temporary list so as not to select them twice in the same turn.
        visibleWords.RemoveAt(index);
    }
    }

   
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

   
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}