using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Luis Manzano", "Division");
        Console.WriteLine(a1.GetSummary());

        Mathematics a2 = new Mathematics (" Cristopher Santos", "Whole Numbers", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        Writing a3 = new Writing("Liza Reyes", "Asian History", "The purpose Great Wall of China");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}