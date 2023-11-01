using System;

class ReflectingActivity : Activity
{
    //Fields
    private List<string> PROMPTS;
    private List<string> QUESTIONS;

    //Methods
    public ReflectingActivity() : base("This activity will help you reflect on times on your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")

    {
        PROMPTS = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult",
            "Think of a time when you help someone in need.",
            "Think of a time when you did something truly helpless. "
        };

        QUESTIONS = new List<string>
        {
            "why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What make this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "How can you keep this experience in the future?"
        
       };
    }
    private List<string> GetQuestions()
    {
        return QUESTIONS;
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(PROMPTS.Count);
        return PROMPTS[index];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(QUESTIONS.Count);
        return QUESTIONS[index];

    }
    public void Run()
    {;
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:" + GetRandomPrompt ());
        Console.WriteLine(GetRandomQuestion());
        DisplayEndingMessage ();
    }
}