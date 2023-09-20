using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        //Do-while list
        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string Response = Console.ReadLine();
            userNumber = int.Parse(Response);
            // Add the numbers that are not zero
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // Compute the Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+= number;
        }
        Console.WriteLine($"The sum is: {sum}.");
        // Compute the Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // Find the maximun
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            { 
                max = number;
            }
        }
        Console.WriteLine($"The maximum is: {max}");   
    }       
}