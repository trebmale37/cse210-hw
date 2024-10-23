using System;

public class Scripture{
    //Creating variables for the class
    Reference _reference;
    List<Word> _words;
    Random _random;

    //Creating a Constructor for the Class
    public Scripture(Reference reference, string text){
        this._reference = reference;
        this._words = new List<Word>();
        this._random = new Random();
        
        //converting a text of string into an array and back to alist of words
        string[] textstring = text.Split(' ');
        foreach(string line in textstring){
            _words.Add(new Word(line));
        }
    }

    public void HideRandomWords(){
         int numberToHide = _random.Next(1,3); // Hide 1-3 words at a time

        // Find random words that are not already hidden and hide them
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = _random.Next(0, _words.Count);
            if (!_words[index].isHidden)
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string DisplayScriptureText()
    {
        string scriptureText = $"{_reference.DisplayRefernce()}\n";
        foreach (Word word in _words)
        {
            scriptureText += word.DisplayWord() + " ";
        }
        return scriptureText.Trim();
    }

    public bool IsCompletlyHidden(){
        foreach (Word word in _words){
            if (!word.isHidden){
                return false;
                }
            }
        return true;
    }
}