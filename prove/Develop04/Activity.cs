using System;
using System.Collections.Generic;

class Activity
{
    //Fields
    private string description;
    protected int durationInSeconds;

    protected string name;

    // Methods
    public Activity (string name, string description)
    {
        this.name = name;
        this.description = description;
    }
    private void ClearCharacters(int charCount)
    {
        if (charCount <= 0)
        {
            Console.WriteLine();
            return;
        }
        if (charCount > description.Length)
        {
            charCount = description.Length;
        }

        string cleareddescription = new string('*', charCount) + description.Substring(charCount);
        description = cleareddescription;
    }
    public void DisplayStartingMessage()
    {
       Console.Write($"Welcome to {name} activity.");
       Console.WriteLine();
       Console.WriteLine();

       Console.Write($"{description}");
       Console.WriteLine();
       Console.WriteLine();

       Console.Write("How long, in seconds would you like for your session? ");
       Console.ReadLine();

       DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(5);

       Thread.Sleep(3000);
       
       DateTime currentTime = DateTime.Now;
       if (currentTime < futureTime)
       {
        Console.WriteLine();
       }
       Console.WriteLine("Get ready...");
       Console.Write("+");

       Thread.Sleep(500);

       Console.Write("\b \b");
       Console.Write("|", "/", "-", "\\");

      
      
    }
    public void DisplayEndingMessage()
    {
       Console.WriteLine("Well done!");

       Console.WriteLine();
       Console.Write($"You have completed another {durationInSeconds} seconds of the {name} activity");
       
       
    }
    protected static void ShowCountCountdownTime(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    protected static void ShowSpinner( int seconds)
    {
        string[] spinnerChars = {"|", "/", "-", "\\"};
        int currentIndex = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine("\r" + spinnerChars[currentIndex] + " ");
            currentIndex = (currentIndex + 1) % spinnerChars.Length;
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.WriteLine();
    }
}