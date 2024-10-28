using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class GoalManager{
    private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
    
    public void Start(){
        bool running = true;
        while (running){
            Console.Clear();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("1. Create Goal\n2. List Goals\n3. Record Event\n4. Save Goals\n5. Load Goals\n6. Exit");
            Console.Write("Select an option: ");
                
            switch (Console.ReadLine())
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
            }
        }
    }

    public void CreateGoal(){
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string goalType = Console.ReadLine();
        Goal goal = null;

        switch (goalType){
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }

        if (goal != null){
                _goals.Add(goal);
                Console.WriteLine("Goal created successfully.");
        }
    }

    public void ListGoalDetails(){
        Console.WriteLine("Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine($"{goal.GetDetailstring()}");
            }
            Console.ReadLine();        
    }

    public void RecordEvent(){
            Console.WriteLine("Select a goal to record an event:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailstring()}");
            }

            int choice = int.Parse(Console.ReadLine()) - 1;
            if (choice >= 0 && choice < _goals.Count)
            {
                //_score += _goals[choice].RecordEvent();
            }
            Console.ReadLine();        
    }

    public void SaveGoals(){
        Console.Write($"Enter the name of the file You want to save to: ");
        string file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved.");
            Console.ReadLine();        
    }

    public void LoadGoals(){
        Console.Write($"Enter the name of the file to load from: ");
        string file = Console.ReadLine();
        if (File.Exists(file)){
             _goals.Clear();
            using (StreamReader reader = new StreamReader(file)){
                    _score = int.Parse(reader.ReadLine());
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        Goal goal = null;

                        switch (parts[0])
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) /*{ IsComplete = bool.Parse(parts[4])}*/ ;
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                                ((ChecklistGoal)goal)._amountCompleted = int.Parse(parts[4]);
                                break;
                        }

                        if (goal != null)
                        {
                            _goals.Add(goal);
                        }
                    }
                }
                Console.WriteLine("Goals loaded.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
            Console.ReadLine();
    }
}
