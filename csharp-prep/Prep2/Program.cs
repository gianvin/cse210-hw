using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentag? ");
        string grade = Console.ReadLine();

        if (grade >= "90")
        {   
           Console.WriteLine("A");
        }
        else if (grade >= "80")
        {
           Console.WriteLine("B");
        }
        
        else if (grade >= "70")
        {
           Console.WriteLine("C");
        }
        else if (grade >= "60")
        {
           Console.WriteLine("D");
        }
        else 
        {
           Console.WriteLine("F");
       
        
        if (grade == "70" || >= "70")
        { 
            Console.WriteLine("Congratulations! You passed the course. ");
        }
        else
        {
            Console.WriteLine("Next time, Study hard. ")
        }

    }


}