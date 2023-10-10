public class Entry
{
   // Menu
    public int _choice = 0;
    

    // Method
    public Entry()
    {
        
    }
    public List<string> DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices ");
        Console.WriteLine("1. Write"); 
        Console.WriteLine("2. Display"); 
        Console.WriteLine("3. Load"); 
        Console.WriteLine("4. Save"); 
        Console.WriteLine("5. Quit");

        return menu;
    }
    public List<string> _journal;
    public void DisplayJournal()
    {
        //print entry in the journal line by line
        Console.WriteLine("What is the filename? ");
        string answer = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(answer);
        _journal.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            string dateFile = parts[0];
            string first = parts[1];
            string last = parts[2];
            Console.WriteLine($"{dateFile} - {first}");
            Console.WriteLine($" - {last}");
            string entry = $"{dateFile} - {first} - {last}";
            _journal.Add(entry);
        }
  
    public void WriteJournal(){
        //display propmt
        Prompt Prompt = new Prompt();
        _prompts = Prompt.GetPrompt();
        Console.WriteLine(_prompts);
        //Save the entry
        _entry = Console.ReadLine();
        //save the current
        DateTime theCurrentTime = DateTime.Now
        string dateText = theCurrentTime.ToShortDateString();
        //add entry with date
        _pages.Add(Date: + dateText + " - Promt: " + _prompt);
        _pages.Add(_entry):
    public void LoadJournal()
    {

    }
    public void SaveJournal(){
        
    }
    }
}  
