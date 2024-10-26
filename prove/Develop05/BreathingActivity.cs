using System;

public class BreatingActivity : Activity{
    public BreatingActivity() : base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine();
        //Creating variable to store the duration for the program
        int remainingTime = duration;
        while (remainingTime > 0){
            Console.WriteLine("Breath In ");
            ShowCountDown(3);
            Console.WriteLine("Breath Out");
            ShowCountDown(3);
            remainingTime -= 6;
        }
        Console.WriteLine();
        DisplayEndingMesssage();
    }
}