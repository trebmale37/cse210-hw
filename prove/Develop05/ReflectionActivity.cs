using System;
using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity {

    private List<string> _prompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){

    }
    
    //creating methods
    public void Run(){
        DisplayStartingMessage();

        //creating a random list of prompts
        Random ran = new Random();

        //getting a random prompt from the list
        int index = ran.Next(_prompts.Count);
        Console.WriteLine($"Consider the following prompt\n");
        Console.WriteLine($"------{_prompts[index]}------\n");
        Console.WriteLine($"When you have something in mind press the enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following question as they are related to this experience;\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        //pulling reflect questions from a list of questions
        int remainingTime = _duration;
        while(remainingTime > 0){
            Console.Write("  >>");
            int i = ran.Next(_questions.Count);
            Console.WriteLine(_questions[i]);
            ShowSpinner(6);
            remainingTime-= 6;            
        }
        Console.WriteLine();
        DisplayEndingMesssage();
    }
}