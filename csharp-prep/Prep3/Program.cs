using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? 6");
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int number = int.Parse(guess);
        
        string word = "";

        if (number < 6)
        {
           word = "higher";
        }
        else if (number > 6)
        {
            word = "lower";
        }
        else 
        {
           word = "You guessed it!";
        }
        Console.WriteLine($"{word}");
    }   
            
}