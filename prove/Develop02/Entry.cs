using System.Collections.Generic;
public class Write
{
    public string _date;
    public List<string> _journal;
    public List<string> _prompts;

    public void Display()
    {
        Random rnd = new Random();
        string anyPrompt = _prompts[rnd.Next(10)];
        Console.WriteLine(anyPrompt);
        string answer = Console.ReadLine();
        string entry = ($"Date: {_date} - Prompt: {anyPrompt} - {answer}. ");
        _journal.Add(entry);
    }
}