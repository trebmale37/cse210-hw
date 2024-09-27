using System;

public class Resume{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void Message(){
        //Displays the resume, which shows the name first, followed by displaying 
        //each one of the jobs.
        Console.WriteLine($"{_personName}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs){
            job.DisplayMessage();
        }
    }  
}