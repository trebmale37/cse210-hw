using System;
using System.Dynamic;

public abstract class Goal{
    //creating variables for attributes for the class
    private string _shortName;
    private string _description;
    private int _points;

    //Creating a constructor for the class
    public Goal(string goalName, string goalDescription, int points){
        this._shortName = goalName;
        this._description = goalDescription;
        this._points = points;
    }
    //Creating properties for the class
    public string goalName{get {return _shortName;}}
    public string goalDescription{get {return _description;}}
    public int points{get {return _points;}}

    //Creating methods for the class
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailstring(){
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}: ({_description})";
    }
    public abstract string GetStringRepresentation();
}