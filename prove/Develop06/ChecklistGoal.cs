using System;
using System.Dynamic;

public class ChecklistGoal : Goal{
    //Creating attributes 
    public int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string goalname, string description, int points,int target, int bonus) : base(goalname, description, points){
        _amountCompleted = 0;
        this._target = target;
        this._bonus = bonus;
    }

    //Properties of the attributes 
    public int target{get {return _target;}}
    public int bonus{get {return _bonus;}}
    

    public override void RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = points;
        if (_amountCompleted >= _target)
            {
                pointsEarned += _bonus;
                Console.WriteLine("Checklist goal completed! You earned a bonus!");
            }
        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
    }
    public override bool IsComplete(){
        return _amountCompleted >= _target;
    }
    public override string GetDetailstring()
    {
        return $"{base.GetDetailstring()} ({_amountCompleted} / _{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal | {goalName} -- {goalDescription} -- {points} -- {_amountCompleted} -- {_target} -- {_bonus}";
    }
}