using System;

class ReflectingActivity : Activity
{
    //Fields
    private List<string> PROMPTS;
    private List<string> Questions;

    public ReflectingActivity() : base(" This activity will help you reflect on times on your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        PROMPTS = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult",
            "Think of a time when you help someone in need.",
            "Think of a time when you did something truly helpless. "
        };
    }
}