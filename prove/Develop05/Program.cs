using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        
        
        Console.WriteLine($"You have 0 points");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Menu Option: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        while (choice != "6")
        {
            if (choice == "1")
            {
            Console.WriteLine("The Types of Goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string goalChoice = Console.ReadLine();
                if(goalChoice == "1")
                    {
                //SimpleGoal simpleGoal = new SimpleGoal();
                Console.Write("What is the name of your goal? ");
                string userNameInput1 = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string userDesInput = Console.ReadLine();
                Console.Write("How many points is associated to this goal? " );
                string userPoints = Console.ReadLine();
                int points = int.Parse(userPoints);



                    }
                else if (goalChoice == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal("study the scrptures", "to be focused", "50");
                    eternalGoal.SetShortName("");
                    Console.Write("What is the name of your goal? ");
                    string userNameInput1 = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string userDesInput = Console.ReadLine();
                    Console.Write("How many points is associated to this goal? " );
                    string userPoints = Console.ReadLine();
                    int points = int.Parse(userPoints);

                    
                }
                else 
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal("attend the temple", "perform ordinances", "50", 5, 100 );

                    Console.Write("What is the name of your goal? ");
                    string userNameInput1 = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string userDesInput = Console.ReadLine();
                    Console.Write("How many points is associated to this goal? " );
                    string userPoints = Console.ReadLine();
                    int points = int.Parse(userPoints);
                    Console.Write("How many times does this goal need to be accomplished to attract a bonus? ");

                    string timesForBonus = Console.ReadLine();
                    int timesBonus = int.Parse(userPoints);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string userBonus = Console.ReadLine();
                    int bonus = int.Parse(userPoints);

                    
                }

            }
            else if (choice == "2")
            {

            }

        }

       


        GoalManager goalManager = new GoalManager();
        
    }
}