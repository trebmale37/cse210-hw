using System;
using System.Collections.Generic;
public class ListingActivity : Activity{
    //Creating a lsit variable
    
    private int _count;
    private List<string> _response = new List<string>();

    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run(){
        //Displaying the start message
        DisplayStartingMessage();
        Console.WriteLine();

        //Displaying a randome prompt question from the list of prompts
        //Creating a random method
        Random ran = new Random();

        int index = ran.Next(_prompts.Count());
        //Getting a random prompt from the list of prompts
        Console.WriteLine(_prompts[index]);
        ShowCountDown(5);
        
        Console.WriteLine("Enter your Response: ");
        
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration){
            Console.Write($"  >>");
            //Taking a list of response from the user
            string response = Console.ReadLine();
            //adding the response to the list of responses
            _response.Add(response);
        }

        //displaying the number of responses that were given
        Console.WriteLine();
        _count = _response.Count();
        Console.WriteLine($"You entered {_count} response");
        ShowSpinner(3);

        Console.WriteLine();
        DisplayEndingMesssage();
        
    }
}