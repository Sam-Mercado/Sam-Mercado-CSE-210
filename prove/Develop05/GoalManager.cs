using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        //display menu
        //call: 
        // Create goald, List goal details, save goals, load goals
        //record event  
        int choice = 0;
        Console.Clear();
        DisplayPlayerInfo();

        Console.WriteLine("1.Create a new goal: ");
        Console.WriteLine("  2. List goals ");
        Console.WriteLine("  3. Save goals ");
        Console.WriteLine("  4. Load goals ");
        Console.WriteLine("  5. Record event ");
        Console.Write("Select a choise from the menu:");
        choice = int.Parse(Console.ReadLine());



        switch (choice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalNames();
                break;
            case 3:
                Console.Write("File Name: ");
                string file = Console.ReadLine();
                SaveGoals(file);
                break;
            case 4:
                Console.Write("File Name: ");
                file = Console.ReadLine();
                LoadGoals(file);
                break;
            case 5:
                RecordEvent();
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }

    public void DisplayPlayerInfo()
    {
        //display the points 
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        //loop thought the list of gols and display 
        //the full details 
        int counter = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{counter}. {g.GetDetailsString()}");
            counter++;
        }
    }

    public void CreateGoal()
    {
        //Display a submenu to display a goal type
        //Ask for the name description and points 
        //Ask for more if they pick checklist goal
        //Create an object and add to the goal list 

        bool running = true;
        while (running)
        {
            Console.WriteLine("The type of goals are: ");
            Console.WriteLine("  1. Simple Goal ");
            Console.WriteLine("  2. Eternal Goal ");
            Console.WriteLine("  3. Checklist Goal ");
            int choice = int.Parse(Console.ReadLine());



            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated to this goal?");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //Creating an object and adding it to the list 
                    Goal simple = new SimpleGoal(name, description, points, false);
                    _goals.Add(simple);
                    break;

                case 2:
                    //Creating an object and adding it to the list 
                    Goal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;

                case 3:
                    Console.Write("How many times does this goal need to be compleated for a bonus?");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for acomplihing it that many times?");
                    int bonus = int.Parse(Console.ReadLine());
                    //Creating an object and adding it to the list 
                    Goal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, false);
                    _goals.Add(checklistGoal);

                    break;

                default:
                    Console.WriteLine("Invalid input. Please choose one of the following choices.");
                    break;


            }
            Start();
        }
    }

    public void RecordEvent()
    {

        //Display a list of goals name
        //ask user to selec a goal
        ListGoalNames();
        Console.WriteLine("Select a goal: ");
        //Call record event in the correct 
        //update the score based in the points
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index < 0)
        {
            _score += _goals[index].RecordEvent();
        }
        else
        {
            Start();
        }

    }

    public void SaveGoals(string file)
    {
        string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }

        }
    }

    public void LoadGoals(string name)
    {
        //Ask user for the file name 
        //Read each line of the file and split it up
        //use the parts to recreate the word object 
        string filename = name;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] type = line.Split(":");
            string goaltype = type[0];

            //using the parts to recreate the goals 

            if (goaltype == "SimpleGoal")
            {
                string[] parts = type[1].Split("|");
                string goalname = parts[0];
                string goalDescription = parts[1];
                int goalPoints = int.Parse(parts[2]); //convert the string to integer
                bool goalIsComplete = bool.Parse(parts[3]);////////////

                Goal simpleGoal = new SimpleGoal(goalname, goalDescription, goalPoints, goalIsComplete);

            }
            if (goaltype == "EternalGoal")
            {
                string[] parts = type[1].Split("|");
                string goalname = parts[0];
                string goalDescription = parts[1];
                int goalPoints = int.Parse(parts[2]);
                bool goalIsComplete = bool.Parse(parts[3]);
                Goal eternalGoal = new EternalGoal(goalname, goalDescription, goalPoints);

            }

            else if (goaltype == "CheckListGoal")
            {
                string[] parts = type[1].Split("|");
                string goalname = parts[0];
                string goalDescription = parts[1];
                int goalPoints = int.Parse(parts[2]);
                bool goalIsComplete = bool.Parse(parts[3]);
                int goalBonus = int.Parse(parts[4]);
                int timesDone = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                //string name, string description, int points, int target, int bonus, bool isComplated
                Goal eternalGoal = new ChecklistGoal(goalname, goalDescription, goalPoints, target, timesDone, goalBonus, goalIsComplete);
            }
            else
            {
                Console.WriteLine("You got an error");
                //Start();
            }


        }


    }
}