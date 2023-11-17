using System;

public class ChecklistGoal : CompletableGoal
{
    //fields
    private int bonusAmount;
    private int timesCompleted;
    private int timesToComplete;

    //methods
    public ChecklistGoal(string name, string description, int points, bool goalCompletion, int timesToComplete, int bonusAmount, int goalNumberCompleted) : base(name, description, points)
    {
        this.timesToComplete = timesToComplete;
        this.bonusAmount = bonusAmount;
    }
    public ChecklistGoal(string savedString) : base(savedString)
    {
       
    }

    public ChecklistGoal(string name, string description, int points, int bonusAmount, int timesToComplete) : base(name, description, points)
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