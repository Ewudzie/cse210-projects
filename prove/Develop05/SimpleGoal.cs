using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, string points):base(name, description, points)
    {
        
        name = "";
        description = "";
        points = "";

    }
         public bool GetIsComplete()
         {
            return _isComplete;
         }
         public void SetIsComplete(bool isComplete)
         {
            _isComplete = isComplete;
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