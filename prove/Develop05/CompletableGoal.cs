using System;


public abstract class CompletableGoal : Goal
{
    //fields
    protected bool isComplete;

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
        return $"{base.ToSaveString()},{isComplete}";
    }
}
 