using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Write the menu option
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing activity");
        Console.WriteLine("2. Start Reflecting activity");
        Console.WriteLine("3. Start Listing Actvity");
        Console.WriteLine("4. Start Tapping Activity");
        Console.WriteLine("5. Quit");
        Console.Write("Select a choice from the menu: ");
        int userChoice = int.Parse(Console.ReadLine());
        // Write the if statement
        if (userChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
        else if (userChoice == 2)
            {
               
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
        else if (userChoice == 3)
            {
            
                ListActivity listActivity = new ListActivity();
                listActivity.Run();
            }
        else if (userChoice == 4)
            {
               TappingActivity tappingActivity = new TappingActivity();
               tappingActivity.Run();
            }
        else if (userChoice == 5)
        {
            Console.ReadLine();
        }
        else
        {
            Console.ReadLine();
        }

    }
}