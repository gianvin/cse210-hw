using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Code for menu option
       Console.WriteLine("You have {points} points");
       Console.WriteLine();
       Console.WriteLine("Menu Options");
       Console.WriteLine(" 1. Create New Goal");
       Console.WriteLine(" 2. List Goals");
       Console.WriteLine(" 3. Save Goals ");
       Console.WriteLine(" 4. Load Goals");
       Console.WriteLine(" 5. Record Event");
       Console.WriteLine(" 6. Quit");
       Console.Write("Select a choice from the menu: ");
       int userChoice = int.Parse(Console.ReadLine());

        // Code for if statement

        if (userChoice == 1)
        {
            Console.WriteLine("The types of Goals are:");
            Console. WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of Goal would you like to create? ");
            int choiceGoal = int.Parse(Console.ReadLine());
            if (choiceGoal == 1)
            {
                 Console.Write("Which type of goal would you like to create? ");
                 Console.Write("What is the name of your goal? ");
                 Console.Write("What is a short description of this goal? ");
                 Console.Write("What is the amount of points associated with this goal? " );
        
            }
            else if (choiceGoal == 2)
            {
                Console.Write("Which type of goal would you like to create? ");
                Console.Write("What is the name of your goal? ");
                Console.Write("What is a short description of this goal? ");
                Console.Write("What is the amount of points associated with this goal? " );
            }
            else if (choiceGoal == 3)
            {
                Console.Write("Which type of goal would you like to create? ");
                Console.Write("What is the name of your goal? ");
                Console.Write("What is a short description of this goal? ");
                Console.Write("What is the amount of points associated with this goal? " );
                Console.Write("How many times does this goal need to be accomplished for a bonus? " );
                Console.Write("What is the bonus for accomplishing it that many times?" );
            }
            else
            {
                Console.ReadLine();
            }

              
      
        } 
        else if (userChoice == 2)
        {
            Console.WriteLine("The goals are:");
        
        }

    //SimpleGoal simpleGoal = new SimpleGoal('Simple Goal', 'This is a simple goal', 5");
    //EternalGoal eternalGoal = new EternalGoal('Eternal Goal', 'This is an eternal Goal', 10);
    //ChecklistGoal checklistGoal = new ChecklistGoal(' Checklist Goal', 'This is a checklist goal', 8, 3, 2');
     

       

       //Record Events
       //int bonusPoints = checklistGoal.RecordEvent();
       //Console.WriteLine();

      
       //Console.WriteLine(simpleGoal.ToString());
       // Console.WriteLine(eternalGoal.ToString());
       //Console.WriteLine(checklistGoal.ToString());

    }
}