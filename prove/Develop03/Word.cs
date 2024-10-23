using System;
public class Word{
    //Creating varibales for the class word
    private string _text;
    public bool isHidden;

    //Creating a constructor for the class
    public Word(string text){
        this._text = text;
        isHidden = false;
    }

    //Creating of properties for the variables
    public string text{get {return _text;}}

    //Method for the class Word
    public void Hide(){
        isHidden = true;
    }

    public string DisplayWord(){
        return isHidden ? "_____" : _text;
    }
}