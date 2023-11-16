using System;

public abstract class ChecklistGoal : CompletableGoal
{
    //fields
    private int bonusAmount;
    private int timesCompleted;
    private int timesToComplete;

    //methods
    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount) : base(name, description, points)
    {
        this.timesToComplete = timesToComplete;
        this.bonusAmount = bonusAmount;
    }
    public ChecklistGoal(string savedString) : base(savedString)
    {
       
    }
    public override int RecordEvent()
    {
      timesCompleted++;
      if (timesCompleted == timesToComplete)
      {
        isComplete = true;
        points += bonusAmount;
      }
      return bonusAmount;
    }



}