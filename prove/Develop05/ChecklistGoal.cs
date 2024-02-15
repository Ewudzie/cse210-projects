using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal (string name, string description, string points, int target, int bonus):base(name, description, points)
    {
        
        name = "";
        description = "";
        points = "";

    }
        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }
        public int GetTarget()
        {
            return _target;
        }
        public int GetBonus()
        {
            return _bonus;
        }
        public void SetAmountCompeleted(int amountCompleted)
        {
            _amountCompleted = amountCompleted;
        }
        public void SetTarget(int target)
        {
            _target = target;
        }
        public void SetBonus(int bonus)
        {
            _bonus = bonus;

        }

    

     public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool isComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentative()
    {
        throw new NotImplementedException();
    }
}