using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Write the menu option
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start Listing Actvity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int userChoice = int.Parse(Console.ReadLine());
        // Write the if statement
        if (userChoice == 1)
            {
                Console.WriteLine("Welcome to the Breathing Actvity. ");  
                Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.Write("How long, in seconds, would you like for your session? ");
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
        else if (userChoice == 2)
            {
                Console.WriteLine("Welcome to the Reflecting Activity. ");
                Console.WriteLine("This activity will help you reflect on times on your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.Write("How long, in seconds, would you like for your session? ");
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
        else if (userChoice == 3)
            {
                Console.WriteLine("Welcome to the Listing Activity. ");
                Console.WriteLine("This activity will help you rflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.Write("How long, in seconds, would you like for your session? ");
                ListActivity listActivity = new ListActivity();
                listActivity.Run();
            }
        else if (userChoice == 4)
        {
            
        }
        else
        {
            Console.ReadLine();
        }

    }
}