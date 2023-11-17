using System;

public class EternalGoal : Goal
{
    //methods
    public EternalGoal(string name, string description, int points) : base(name, description, points) 
    {
        
    }
    public EternalGoal(string savedString) : base(savedString)
    {
      
    }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
}