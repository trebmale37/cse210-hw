using System;
using System.Diagnostics;

public class Activity{
    //Creating attributes for the class
    private  string  _name;
    private  string _description;
    protected  int _duration;

    //Creating a constructor of the class Activity
    public Activity(string name, string description){
        this._name = name;
        this._description = description;
    }

    //Creating Properties for the attributes
    public string name{get {return _name;}}
    public string description{get {return _description;}}
    public int duration{get {return _duration;}}

    //Creating method for the class
    public virtual void DisplayStartingMessage(){
        Console.WriteLine($"{name}");
        Console.WriteLine($"{description}");
        Console.Write($"Please Enter the duration of this activity: ");
        _duration = int.Parse(Console.ReadLine());
        ShowSpinner(3);
    }

    public virtual void DisplayEndingMesssage(){
        Console.WriteLine($"You have done a great Job.");
        ShowSpinner(3);
        Console.WriteLine($"You completed the {name} in {duration} seconds");
        ShowSpinner(3);
    }

    //Method for showing the spinner and waiting for the countdown
    public virtual void ShowSpinner(int seconds){              
        for (int i = 0; i < seconds; i++)
        {
            
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b\b  \b\b  \b\b  \b\b \b\b");
        }
        Console.Write($"");
    }

    //method for the countdown
    public virtual void ShowCountDown(int seconds){
        for(int i = seconds; i > -1; i--){
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b \b\b \b\b");
        }
        Console.WriteLine();
    }

}