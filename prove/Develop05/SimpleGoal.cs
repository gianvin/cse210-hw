using System;

public abstract class SimpleGoal : CompletableGoal
{
    //methods
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
       
    }

    public SimpleGoal(string savedString) : base(savedString)
    {
      
    }

    public override int RecordEvent()
    {
     return 0;    
    }


}