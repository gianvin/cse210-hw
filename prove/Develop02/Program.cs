using System;
using System.Runtime.InteropServices.Marshalling;
using System.IO;
string filename = "myFile.txt";
string[] lines = System.IO.File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");
    string _date = parts[0];
    string _prompt = parts[1];
    string _response = parts[2];
}
DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToShortDateString();

Console.WriteLine("Welcome to the Journal Program! ");
Console.WriteLine("Please select one of the following choices: ");
Console.WriteLine(" 1. Write");
Console.WriteLine(" 2. Display");
Console.WriteLine(" 3. Load");
Console.WriteLine(" 4. Save");
Console.WriteLine(" 5. Quit");
Console.Write("What would you like to do? ");
string choice = Console.ReadLine();
int prompt = int.Parse(choice);

string prompt = "";

if (choice == 1)
{
    prompt = "Who was the most interesting person I interacted with today?";
}
else if (choice == 2)
