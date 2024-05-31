using System;
using System.IO;
public class GoalManager
{
    protected List<Goal> _goals;
    protected int _score;

    public GoalManager()
    {
        _score = 0;



    }

    public void Start()
    {
        //display menu
        //call: 
        // Create goald, List goal details, save goals, load goals
        //record event  
        string choice = "";
        Console.Clear();

        Console.WriteLine("Create a new goal: ");
        Console.WriteLine("  1. List goals ");
        Console.WriteLine("  2. Save goals ");
        Console.WriteLine("  3. Load goals ");
        Console.WriteLine("  4. Record event ");
        Console.Write("Select a choise from the menu:");
        choice = Console.ReadLine();


    }

    public void DisplayPlayerInfo()
    {
        //display the points 
        Console.WriteLine(_score);
    }

    public void ListGoalNames()
    {
        //loop thought the list of gols and display 
        //the full details 
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g);
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

            string name = "";
            String description = "";
            int points = 0;

            switch (choice)
            {

                case 1:

                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("Whaat is the amount of points associated to this goal?");
                    points = int.Parse(Console.ReadLine());


                    //Creating an object and adding it to the list 
                    List<Goal> simple = new List<Goal>();
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simple.Add(simpleGoal);


                    break;

                case 2:

                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("Whaat is the amount of points associated to this goal?");
                    points = int.Parse(Console.ReadLine());


                    //Creating an object and adding it to the list 
                    List<Goal> goals = new List<Goal>();
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    goals.Add(eternalGoal);

                    break;

                case 3:
                    int target = 0;
                    int bonus = 0;
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("Whaat is the amount of points associated to this goal?");
                    points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be compleated for a bonus?");
                    target = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for acomplihing it that many times?");
                    bonus = int.Parse(Console.ReadLine());


                    //Creating an object and adding it to the list 
                    List<Goal> _goals = new List<Goal>();
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);

                    break;

                default:
                    Console.WriteLine("Invalid input. Please choose one of the following choices.");
                    break;


            }



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
        //Display current points 




    }

    public void SaveGoals(string file, string text)
    {
        string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(text);
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
            string[] parts = line.Split("|");
            string goaltype = parts[0];

            //using the parts to recreate the goals 

            if (goaltype == "EternalGoal" || goaltype == "SimpleGoal")
            {
                string goalname = parts[1];
                string goalDescription = parts[2];
                string goalPointsStr = parts[3]; int goalPoints = int.Parse(goalPointsStr);//convert the string to integer

                Console.WriteLine($"{goaltype} {goalname} ({goalDescription}) {goalPoints}");
            }

            else if (goaltype == "CheckListGoal")
            {
                string goalname = parts[1];
                string goalDescription = parts[2];
                string bonusPoints = parts[3];
                string timesDone = parts[4];
                string timesToGetDone = parts[5];
                string goalPointsStr = parts[6]; int goalPoints = int.Parse(goalPointsStr);

                Console.WriteLine($"{goaltype} {goalname} ({goalDescription}) {bonusPoints} {timesDone}/{timesToGetDone} {goalPoints}");
            }
            else
            {
                Console.WriteLine("You got an error");
                //Start();
            }


        }


    }
}