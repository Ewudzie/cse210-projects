using System;

public class EternalGoal : Goal
{

    public EternalGoal (string name, string description, string points):base(name, description, points)
    {
        
        name = "";
        description = "";
        points = "";

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