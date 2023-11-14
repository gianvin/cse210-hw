using System;

public abstract class ChecklistGoal : CompletableGoal
{
    //fields
    private int bonusAmount;
    private int timesCompleted;
    private int timesTocomplete;

    //methods
    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount) : base(name, description, points)
    {
        this.timesTocomplete = timesToComplete;
        this.bonusAmount = bonusAmount;
    }
    public ChecklistGoal(string savedString) : base(savedString)
    {

    }



}