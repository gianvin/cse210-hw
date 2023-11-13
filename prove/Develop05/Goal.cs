using System;
using System.Diagnostics;

abstract class Goal
{
   protected string description;

   protected int points;

   public string Name {get; set;}

   public Goal(string name, string description, int points)
   {
    this.Name = name;
    this.description = description;
    this.points = points;
   }


   
}