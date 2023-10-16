using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Program
{
    private static object _prompts;

    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program! ");
        string date = DateTime.UtcNow.ToString("yyyy-mm-dd");
        string response = "yes";
        List<string> journal = new List<string>();
        List<string> prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"};
        // Write the choices for the user
        while (response == "yes" )
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1. Write"); 
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load"); 
            Console.WriteLine("4. Save"); 
            Console.WriteLine("5. Edit");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
               {
                Write writeNew = new Write();
                writeNew._date = date;
                writeNew._journal = journal;
                writeNew._prompts = _prompts;
                response = "yes";
               }
            else if (userChoice == 2)
               {
                 Show displayNew = new Show();
                 displayNew._journal = journal;
                 displayNew.Display();
                 response = "yes";
               }
            else if (userChoice == 3)
               {
                Load loadNew = new Load();
                loadNew._journal = journal;
                loadNew.Display();
                response = "yes";
               }
            else if (userChoice == 4)
               {
                 Save saveNew = new Save();
                 saveNew._journal = journal;
                 saveNew.Display();
                 response = "yes";
               }
            else if (userChoice == 5)
              {
                 Edit editNew = new Edit();
                 editNew._journal = journal;
                 editNew.Display();
                 response = "yes";
                
              }
            else if (userChoice == 6) 
            {
              
            } 
            else if (userChoice < 0 || userChoice > 6)
            {
               response = "no";
            }
    }  

   
private class Edit
    {
        internal List<string> _journal;

        internal void Display()
        {
            throw new NotImplementedException();
        }
    }
}

internal class Save
{
    internal List<string> _journal;

    public Save()
    {
    }

    internal void Display()
    {
        throw new NotImplementedException();
    }
}

internal class Load
{
    internal List<string> _journal;

    internal void Display()
    {
        throw new NotImplementedException();
    }
}

internal class Show
{
    internal List<string> _journal;

    internal void Display()
    {
        throw new NotImplementedException();
    }
}

internal class Write
{
    internal string _date;
    internal List<string> _journal;
    internal object _prompts;
}