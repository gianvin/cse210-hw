using System;
using System.Collections.Generic;

class Activity
{
    //Fields
    private string description;
    protected int durationInSeconds;

    private string name;
    private int seconds;

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

       Console.WriteLine("Get ready...");

       string[] spinnerChars = {"|", "/", "-", "\\"};
       int currentIndex = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine("\r" + spinnerChars[currentIndex] + " ");
            currentIndex = (currentIndex + 1) % spinnerChars.Length;
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.WriteLine();
      
    }
    public void DisplayEndingMessage()
    {
       Console.WriteLine("Well done!");
       Console.WriteLine();

       Console.Write($"You have completed another {durationInSeconds} seconds of the {name} activity");
    }
    private static void ShowCountCountdownTime(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    private static void ShowSpinner( int seconds)
    {
        string[] spinnerChars = {"|", "/", "-", "\\"};
        int currentIndex = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine("\r" + spinnerChars[currentIndex] + " ");
            currentIndex = (currentIndex + 1) % spinnerChars.Length;
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.WriteLine();
    }
}