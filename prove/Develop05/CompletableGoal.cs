using System;


public abstract class CompletableGoal : Goal
{
    protected bool isComplete;

    protected CompletableGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }
}
 