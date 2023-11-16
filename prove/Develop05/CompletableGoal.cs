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
        Console.Write("Which type of goal would you like to create? ");
       Console.Write("What is the name of your goal? ");
       Console.Write("What is a short description of this goal? ");
       Console.Write("What is the amount of points associated with this goal? " );
    }
    public override string ToSaveString()
    {
        return $"{base.ToSaveString()},{isComplete}";
    }
}
 