using System;
using System.Threading.Tasks.Dataflow;

public class Entry
{
   public int _response = 0;
   //Initialize the list for new list
   
   public void DisplayPrompt()
   {
    Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine(" 1. Write");
        Console.WriteLine(" 2. Display");
        Console.WriteLine(" 3. Load");
        Console.WriteLine(" 4. Save");
        Console.WriteLine(" 5. Quit");
        
   }
   public void UpdateUserResponse()
   {
    Console.Write("What would you like to do? ");
   }

}


