using System;

public class Entry{
    //Declaring Variables
    public string _date;
    public string _promptText;
    public string _entryText;

    public string entryDisplay(){
        //Display the response, the prompt, and the date as an Entry.
        return $"Date: {_date} -Prompt: {_promptText}: {_entryText} ";
    }
}