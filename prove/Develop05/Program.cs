using System;
using System.Collections;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
  private static int _score;

  private static List<Goal>goals = new List<Goal>();
  public static void SetScore(int score)
  {
    _score = score;
  }

  public int GetScore()
  {
    return _score;
  }
  static void Main(string[] args)
  {
    int userChoice;
    string fileName;
    int i;
    do
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
      userChoice = int.Parse(Console.ReadLine());


      switch (userChoice)
      {
        case 1: //create new Goal
          Console.WriteLine("The types of Goals are:");
          Console.WriteLine("1. Simple Goal");
          Console.WriteLine("2. Eternal Goal");
          Console.WriteLine("3. Checklist Goal");

          int goalChoice;

          do
          {
            Console.Write("Which type of Goal would you like to create? ");
            goalChoice = int.Parse(Console.ReadLine());


            string name;
            string description;
            int points;
            int bonusAmount;
            int timesToComplete;


            switch (goalChoice)
            {
              case 1: //simple goal
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("what is the amount of points associated with it? ");
                points = int.Parse(Console.ReadLine());

                goals.Add(new SimpleGoal(name, description, points));
                break;


              case 2: // eternal goal
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("what is the amount of points associated with it? ");
                points = int.Parse(Console.ReadLine());

                goals.Add(new EternalGoal(name, description, points));
                break;


              case 3: //checklist goal
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with it? ");
                points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                timesToComplete = int.Parse(Console.ReadLine());
                Console.Write("What is the bounus for accomplishing it that many times? ");
                bonusAmount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, bonusAmount, timesToComplete));
                break;

            }
          } while (goalChoice < 1 || goalChoice > 3);
          break;

        case 2: //list goals
          Console.WriteLine("The goals are:");
          foreach (Goal goal in goals)
          {
            Console.WriteLine(goal.ToString());
          }
          break;

        case 3: // save goals
          Console.Write("What is the filename for the goal file? ");
          fileName = Console.ReadLine();

          using (StreamWriter outputFile = new StreamWriter(fileName))
          {
            outputFile.WriteLine($"{_score}");

            foreach (Goal goal in goals)
            {
              outputFile.WriteLine(goal.ToSaveString());
            }

          }
          break;
        case 4: //load goals

          Console.Write("What is the filename for the goal file? ");
          fileName = Console.ReadLine();
          string[] lines = System.IO.File.ReadAllLines(fileName);
          i = 1;

          foreach (string line in lines)
          {
            if (i == 1)
            {
              continue;

            }
            else
            {
              string[] parts = line.Split(',', ':');

              string goalType = parts[0];
              string goalName = parts[1];
              string goalDescription = parts[2];
              int goalPoints = int.Parse(parts[3]);
              bool goalCompletion;
              int goalBonusAmount;
              int goalNumberToCompletion;
              int goalNumberCompleted;


              switch (goalType)
              {
                case "SimpleGoal":
                  goalCompletion = bool.Parse(parts[4]);
                  goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                  break;

                case "EternalGoal":
                  goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                  break;

                case "CheckListGoal":
                  goalCompletion = bool.Parse(parts[4]);
                  goalBonusAmount = int.Parse(parts[5]);
                  goalNumberToCompletion = int.Parse(parts[6]);
                  goalNumberCompleted = int.Parse(parts[7]);
                  goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalCompletion, goalBonusAmount, goalNumberToCompletion, goalNumberCompleted));

                  break;
              }
            }
            i++;
          }
          break;

        case 5: //record event

    Console.WriteLine("The goals are:");

    i = 1;

       foreach (Goal goal in goals)
       {
         Console.WriteLine($"{i}.{goal.GetName()}");
         i++;
       }
          Console.Write("Which goal did you accomplish? ");
          goalChoice = int.Parse(Console.ReadLine());
          int currentScore = goals[goalChoice - 1].RecordEvent();
          _score += currentScore;
          
          Console.WriteLine($"Congratulations! You have earned {currentScore} points");
          Console.WriteLine($"You now have {_score} points.");
          break;

        case 6: //quit the program

          break;


      }
    } while (userChoice != 6);

  }
}