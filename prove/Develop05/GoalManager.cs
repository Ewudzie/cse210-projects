using System;


public class GoalManager 
{
    private List<Goal>_goals = new List<Goal>();

    private int _score;

    public GoalManager()
    {

    }
    

    public GoalManager (string name, string descripbtion, string points, List<Goal> goals, int score)
    {

        _goals = goals;
        _score = score;

    }
        

    public void Start()
    {
        Console.Write("Welcome To Enternal Quest Game ");

    }
    public void DisplayPlayerInfo(string playerInfo)
    {
        
    }
    public void ListGoalName()
    {

    }

    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }




}