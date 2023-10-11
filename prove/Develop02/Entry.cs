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
public class Show
{
    public List<string> _journal;
    public void Display()
    {
        for (int i = 0; i < _journal.Count;i++)
        {
            string show = _journal [i];
            Console.WriteLine(show);
        }
    }
}
public class Load
{
    public List<string> _journal;
    private object dateFile;

    public void Display()
    {
        Console.WriteLine("What is the file name?");
        string answer = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(answer);
        _journal.Clear();
        foreach (string line in lines)
        {
            string[] parts =line.Split(" - ");
            string datefile = parts[0];
            string first = parts[1];
            string last = parts[2];
            Console.WriteLine($"{dateFile} - {first}");
            Console.WriteLine($" - {last}");
            string entry = ($"{dateFile} - {first} - {last}");
            _journal.Add(entry);        }
    }
  public class Save
  {
    public List<string> _journal;
    public void Display()
    {
        Console.WriteLine("What is the file name? ");
            string answer = Console.ReadLine();
            using (StreamWriter sw = File.CreateText(answer))
            {
                for (int i = 0; i < _journal.Count; i++)
                {
                    string entry = _journal[i];
                    sw.WriteLine(entry);
                }
            }
    }
  }  
}