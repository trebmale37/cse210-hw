using System;

public class PromptGenerator{
    //Creating a variable called list
    public List<string>_prompt = new List<string>(){
        "What was the strongest emotion I felt today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "When was the sadest day in your life?",
        "who is this one person that always make you have a joyous day"
    };

    //Creating a Randome generator
    Random ran = new Random();

    public string showlist(){
       //Declaring a variable to get a random element from the list
       int index = ran.Next(_prompt.Count);

        return _prompt[index];
    }
}
