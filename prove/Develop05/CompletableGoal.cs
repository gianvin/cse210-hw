using System;


public abstract class CompletableGoal : Goal
{
    //fields
    protected bool isComplete;
    protected new object name;

    //methods

    protected CompletableGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }

    protected CompletableGoal(string savedString) : base(savedString)
    {
        
    }
    public override string ToSaveString()
    {
        return $"{GetType().Name}:{name},{description}, {points},{isComplete}";
    }
    public override string ToString()
    {
      if(isComplete)
      {
        return $"{GetType().Name}:{name},{description}, {points}, {isComplete}";
       
      }else
       if(isComplete)
      {return $"[X] {name} ({description})";
      }else
      {
        return $"[] {name} ({description})";
      }
    }
}
 