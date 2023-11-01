using System;
using System.ComponentModel.DataAnnotations;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathe in", "Breathe out")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowBreatheInMessage(5);
        ShowBreatheOutMessage(5);
        DisplayEndingMessage();
    }
   private void ShowBreatheInMessage(int duration)
   {
     Console.WriteLine($"Breathe in");
   }
   private void  ShowBreatheOutMessage(int duration)
   {
     Console.WriteLine($"Breathe out");
   }
}
