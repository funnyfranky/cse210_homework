using System;
using System.Runtime.CompilerServices;

namespace Develop06;

public class GoalManager
{
    public List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }
    public void AddToScore(int score)
    {
        _score += score;
    }

    public void Start()
    {
        int userChoice;
        string input;
        do
        {
            DisplayPlayerInfo();
            Console.Write("\nMenu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Goals\n\t6. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();
            userChoice = NumChecker(input);
            if (userChoice == -1 || userChoice < 1 || userChoice > 6)
            {
                Console.WriteLine($"That isn't a valid response! Try again! (\"{input}\")\n");
            }
            else
            {
                switch (userChoice)
                {
                    case 1: // Create new goal
                        CreateGoal();
                        break;
                    case 2: // List Goals
                        ListGoalDetails();
                        break;
                    case 3: // Save Goals
                        Console.WriteLine("Saving...");
                        SaveGoals("../../../" + "savedGoals" + ".txt");
                        Console.WriteLine("Saving successful!");
                        break;
                    case 4: // Load Goals
                        LoadGoals("../../../" + "savedGoals" + ".txt");
                        break;
                    case 5: // Record Goals
                        RecordEvent();
                        break;
                    default: // Exit
                        Console.WriteLine("Thanks for playing!");
                        break;
                }

            }
        } while (userChoice != 6);
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"User current Points: {_score}\n{_goals.Count} goals.");
    }
    private void ListGoalNames()
    {
        int parseValue = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"\t{parseValue}. {g.GetName()}");
            parseValue++;
        }
    }
    private void ListGoalDetails()
    {
        Console.WriteLine($"User current Points: {_score}\n{_goals.Count} goals:");
        int list = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{list,2}. [{g.ExOrNah()}] {g.GetDetailsString()}");
            list++;
        }
    }
    private void CreateGoal()
    {
        Console.Write($"\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhat kind of goal do you want to add?: ");
        int user2Choice = NumChecker(Console.ReadLine());
        switch (user2Choice)
        {
            case 1:
                _goals.Add(new SimpleGoal());
                break;
            case 2:
                _goals.Add(new EternalGoal());
                break;
            case 3:
                _goals.Add(new ChecklistGoal());
                break;
            default:
                Console.WriteLine("That wasn\'t an option. Try again!");
                break;
        }
    }
    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.WriteLine("What goal did you accomplish?: ");
        int index = NumChecker(Console.ReadLine()) - 1;
        _goals[index].RecordEvent(this);
        AddToScore(_goals[index].GetPoints());
    }
    private void SaveGoals(string fileName)
    {
        using StreamWriter file = new(fileName);
        file.WriteLine($"{GetScore()}");
        foreach (Goal g in _goals)
        {
            file.WriteLine(g.GetStringRepresentation());
        }
    }
    private void LoadGoals(string fileName)
    {
        using StreamReader file = new(fileName);
        string[] inputList = System.IO.File.ReadAllLines(fileName);
        foreach (string line in inputList)
        {
            string[] parts = line.Split("||");
            if (parts.Length >= 2)
            {
                // Name, Description, Points, CompleteStatus
                if (parts[0] == "Develop06.SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                }
                if (parts[0] == "Develop06.EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                if (parts[0] == "Develop06.ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                }
            }
            else { SetScore(int.Parse(parts[0])); }
        }
    }

    private int NumChecker(string n)
    {
        if (int.TryParse(n, out int x))
        {
            return x;
        }
        else
        {
            return -1;
        }
    }

}
