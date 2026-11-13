// Create for Darwin J Tovar.
//for CSE210 in BYU Pathway worldwide.

using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }


    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}