using System;
using System.ComponentModel.Design;
using System.IO;

public class Menu
{
    protected int _score;

    protected int userChoice;

    public Menu()
    {

    }
    public void DisplayMainMenu()
    {
    
    
    }
    public void DisplayCreateNewGoalMenu()
    {
      
    }
    public void UpdateUserChoice()
    {
       
    }
    
    public int GetUserChoice()
    {
        return userChoice;
    }

    internal static void SetScore(int v)
    {
        throw new NotImplementedException();
    }
}