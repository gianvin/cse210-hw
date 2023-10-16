using System.Collections.Generic;
public class Journal
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
            Console.WriteLine($"_date} - {first}");
            Console.WriteLine($" - {last}");
            string entry = $"{dateFile} - {first} - {last}";
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