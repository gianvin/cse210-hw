using System;
using System.Diagnostics;

public abstract class Goal
{ //fields
   protected string description;

   protected int points;

   public string Name {get; set;}

   //methods

   public Goal(string name, string description, int points)
   {
    this.Name = name;
    this.description = description;
    this.points = points;
   }

   public Goal(string savedString)
   {
   
   }
   public abstract int RecordEvent();

   public virtual string ToSaveString()
   {
      return $"{Name},{description}, {points}";
   }

    public override string ToString()
    {
        return $"{Name}: {description}  ({points} points)";
    }

}