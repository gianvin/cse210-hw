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
    public void DisplayJournal(){
        //print entry in the journal line by line
        foreach (string line in _pages){
            Console.WriteLine(line);
        }
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
