using System;

class Program
{
    
    //Display Function
    class Square 
    {
        static void Main() {
            Console.Write("\n\n");
            Console.Write("Welcome to the Program!");
            Console.ReadLine();
            Console.Write($"Please enter your name: ");
        string userName = Console.ReadLine();
            Console.Write("Enter your number: ");
           string input = Console.ReadLine();
          int number = Convert.ToInt32(input);
          int squared = number * number;
          Console.Write("\n\n");
            Console.WriteLine($"{userName}, the square of your number is {squared}");
        }
    }
}    
