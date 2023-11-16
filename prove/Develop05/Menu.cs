using System;
using System.ComponentModel.Design;
using System.IO;

public class Menu
{
    protected int _score;

    private int userChoice;

    public Menu()
    {

    }
    public void DisplayMainMenu()
    {
     Console.WriteLine($"You have {_score} points");
     Console.WriteLine();
     Console.WriteLine("Menu Options");
     Console.WriteLine(" 1. Create New Goal");
     Console.WriteLine(" 2. List Goals");
     Console.WriteLine(" 3. Save Goals ");
     Console.WriteLine(" 4. Load Goals");
     Console.WriteLine(" 5. Record Event");
     Console.WriteLine(" 6. Quit");
     Console.Write("Select a choice from the menu: "); 
    }
    public void DisplayCreateNewGoalMenu()
    {
       Console.WriteLine("The types of Goals are:");
       Console. WriteLine("1. Simple Goal");
       Console.WriteLine("2. Eternal Goal");
       Console.WriteLine("3. Checklist Goal");
       Console.Write("Which type of Goal would you like to create? "); 
    }
    public void UpdateUserChoice()
    {
        int userChoice = int.Parse(Console.ReadLine());
    }
    public int GetUserChoice()
    {
        return userChoice;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public int GetScore()
    {
      return _score;  
    }
}