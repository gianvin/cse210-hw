using System;

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks.Dataflow;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");
        string date = DateTime.UtcNow.ToString("yyyy-mm-dd");
        string response = "yes";
        List<string> journal = new List<string>();
        List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"};
        // Write the choices for the user
        while (response == "yes" )
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1. Write"); 
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load"); 
            Console.WriteLine("4. Save"); 
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

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
                 response = "no";
              }
    }  

}