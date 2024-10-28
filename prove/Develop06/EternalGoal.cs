using System;

public class EternalGoal : Goal{
    public EternalGoal(String goalname, string goaldescription, int points) : base(goalname, goaldescription, points){

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal Commpleted! You earned {points} points");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal | {goalName} -- {goalDescription} -- {points} -- {IsComplete()} ";
    }
}