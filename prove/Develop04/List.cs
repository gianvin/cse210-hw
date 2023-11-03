using System;

class ListActivity : Activity
{
    //fields
    private List<string> PROMPTS;
    protected List<string> userResponse;

    //Methods
    public ListActivity() : base("Listing", "This activity will help you rflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
            PROMPTS = new List<string>
        {
           "---Who are the people you appreciate?---",
           "---What are personal strenghts of yours?---",
           "---Who are people that you have helped this week?---",
           "---When have you felt the Holy Ghost this month?---",
           "---Who are some of your personal heroes?---" 
        }; 

        userResponse = new List<string>();

        

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(PROMPTS.Count);
        return PROMPTS[index];
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: " + GetRandomPrompt());
        Console.Write("You may begin in:");
        Console.WriteLine();

        
        foreach (var prompt in PROMPTS)
        {
            string response = Console.ReadLine();
            userResponse.Add(response);
        }
        Console.WriteLine($"You listed {userResponse.Count} items!");
        DisplayEndingMessage();

    }
}