using System;

public class Reference{
    //Declaring variables 
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    //creating a constructor for the Class Reference
    public Reference(string Book, int Chapter, int Verse){
        this._book = Book;
        this._chapter = Chapter;
        this._startVerse = Verse;
        this._endVerse = Verse;
    }

    //Creating properties for the variables
    public string Book{get {return _book;}}
    public int Chapter{get {return _chapter;}}
    public int Verse{get {return _startVerse;}}
   

    public Reference(string book, int chapter,int startVerse, int endVerse){
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }
    
    //Creating properties for the variables
    public string book{get {return _book;}}
    public int chapter{get {return _chapter;}}
    public int startVerse{get {return _startVerse;}}
    public int endVerse{get {return _endVerse;}}

    //Method to display the reference of the scripture
    public string DisplayRefernce(){
        if(_startVerse == _endVerse){
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else{
            return $"{_book} {_chapter}:{_startVerse} - {_endVerse}";
        }
    }
}