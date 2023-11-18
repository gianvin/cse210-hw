using System;
using System.Runtime.CompilerServices;

public class ChecklistGoal : CompletableGoal
{
    //fields
    
    private int timesCompleted;
   
    private int timesToComplete;
    private int bonusAmount;
    private int completed;

    //methods
    public ChecklistGoal(string name, string description, int points, bool goalCompletion, int timesToComplete, int bonusAmount, int goalNumberCompleted) : base(name, description, points)
    {
        this.bonusAmount = bonusAmount;
        timesCompleted = 0;
        this.timesToComplete = timesToComplete;
        this.timesToComplete = completed;
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
    public override string ToSaveString()
    {
      return $"{GetType().Name}:{name},{description},{points}, {isComplete}, {bonusAmount}, {timesToComplete},{timesCompleted}";
    }

    public override string Tostring()
    {
       if (isComplete)
       {
        return $"[X] {name} [{description})--Currently Completed:{timesCompleted}/{timesToComplete}";

       }else
       {
        return $"[]{name} ({description})--CurrentlyCompleted: {timesCompleted}/{timesToComplete}";
       } 
    }


}