using System;

public class SimpleGoal : Goal{
    //creating an attribute
    private bool _isComplete;
    public SimpleGoal(string goalname, string goaldescription, int points) : base(goalname, goaldescription, points){
       
        _isComplete = false;

    }

    public override void RecordEvent()
    {
            _isComplete = true;
            Console.WriteLine($"Goal Completed! You earned {points} points ");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal | {goalName} -- {goalDescription} -- {points} -- {_isComplete}";
    }
}