using System;
using System.Collections.Generic;

class Activity
{
    //Fields
    private string description;
    private int durationInSeconds;

    private string name;

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
            Console.WriteLine("Invalid character count");
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
      
    }
    public void DisplayEndingMessage()
    {
       // Console.WriteLine($"Well done")
    }
    private void ShowCountCountdownTime(int seconds)
    {
        Console.Write("Get ready...");
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Well done!");
    }
    private void ShowSpinner( int seconds)
    {
        string[] spinnerChars = {"|", "/", "-", "\\"};
        int currentIndex = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.Write(spinnerChars[currentIndex] + " ");
            currentIndex = (currentIndex + 1) % spinnerChars.Length;
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.WriteLine();
    }
}