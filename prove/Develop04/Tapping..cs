using System;

using System.ComponentModel.DataAnnotations;

class TappingActivity : Activity
{
public TappingActivity() : base("Tapping", "This activity will help you relax by tapping your left chest and say 'it's okay' for specific number of times.")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowItsOkayMessage(5);
        DisplayEndingMessage();
    }
    private static void ShowItsOkayMessage(int duration)
   {
     Console.WriteLine($"It's Okay...");

     
        for (int i = 1; i <= 10; i++)
        {
           Console.Write(i);
           Thread.Sleep(2000);
           Console.Write("\b \b");
        }
        Console.WriteLine();
    

   }
}
