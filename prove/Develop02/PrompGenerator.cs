using System.Collections.Generic;
public class Prompt
{
   string[] prompts = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", 
   "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?"};
Random random = new Random();
    private object _prompts;

    public Prompt()
{

}
//Use the method in getting prompt
public string GetPrompt(){
    //Use the random number method and return the prompt
    int randomNumber = _random.Next(0, _prompts.lenght);
    return _prompts[randomNumber];
}
}