using System.Collections.Generic;
public class Entry
{
    public string _date;
    public List<string> _prompts;
    public List<string> _response;

    public Entry(string _date, string )
    public void Display()
    {
        Random rnd = new Random();
        string anyPrompt = _prompts[rnd.Next(10)];
        Console.WriteLine(anyPrompt);
        string answer = Console.ReadLine();
        string entry = ($"Date: {_date} - Prompt: {anyPrompt} - {answer}. ");
        _response.Add(entry);
    }
}
