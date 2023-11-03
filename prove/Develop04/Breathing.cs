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
   private static void ShowBreatheInMessage(int duration)
   {
     Console.WriteLine($"Breathe in...");

     
        for (int i = 1; i <= 5; i++)
        {
           Console.Write(i);
           Thread.Sleep(1000);
           Console.Write("\b \b");
        }
        Console.WriteLine();
    

   }
   private static void  ShowBreatheOutMessage(int duration)
   {
     Console.WriteLine($"Now breathe out...");
    
        for (int i = 5; i >= 0; i--)
        {
           Console.Write(i);
           Thread.Sleep(1000);
           Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.WriteLine();


   }
}
