using System;
using System.ComponentModel.DataAnnotations;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
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
     Console.WriteLine($"Breathe in...");
   }
   private void  ShowBreatheOutMessage(int duration)
   {
     Console.WriteLine($"Now breathe out...");
   }
}
