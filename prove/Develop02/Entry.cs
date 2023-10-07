public class Entry
{
   // Menu
        public int _choice = 0;
    private readonly List<string> menu;

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
    //}    public string _date;
    //public string _prompt;
    //public string _response;

   // public void Display()
    //{
    //    Console.WriteLine($"{_date} ({_prompt})~{_response}");
    }
}