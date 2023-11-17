using System;
using System.Runtime.CompilerServices;

public class ChecklistGoal : CompletableGoal
{
    //fields
    private int _bonusAmount;
    private int timesCompleted;
    private int _timesToComplete;
    private int timesToComplete;
    private int bonusAmount;
    private int completed;

    //methods
    public ChecklistGoal(string name, string description, int points, bool goalCompletion, int timesToComplete, int bonusAmount, int goalNumberCompleted) : base(name, description, points)
    {
        _bonusAmount = bonusAmount;
       timesCompleted = 0;
       _timesToComplete = timesToComplete;
       _timesToComplete = completed;
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
       return bonusAmount + points;
      }else{
        return points;
      }
      
    }



}