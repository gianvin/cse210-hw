using System;
using System.Runtime.CompilerServices;

public class ChecklistGoal : CompletableGoal
{
    //fields
    
    private int timesCompleted;
   
    private int timesToComplete;
    private int bonusAmount;


    //methods
    public ChecklistGoal(string name, string description, int points,  int bonusAmount, int timesToComplete) : base(name, description, points)
    {
        this.bonusAmount = bonusAmount;
        timesCompleted = 0;
        this.timesToComplete = timesToComplete;
    }
    public ChecklistGoal(string name, string description, int points, bool completed, int bonusAmount, int timesToComplete, int timesCompleted): base(name, description, points)
    {
      this.bonusAmount = bonusAmount;
      this.timesCompleted = timesCompleted;
      this.timesToComplete = timesToComplete;
      this.isComplete = completed;
    }
    public ChecklistGoal(string saveString) : base(saveString)
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

    public override string ToString()
    {
    
       if(isComplete)
       {
        return $"[X] {Name} ({description}) -- Currently Completed: {timesCompleted}/{timesToComplete}";

       }
       else
       {
        return $"[]{Name} ({description}) -- CurrentlyCompleted: {timesCompleted}/{timesToComplete}";
       } 
    }


}