using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");
        Prompt Prompt = new Prompt();
        Journal Journal = new Journal();
        do{

        Prompt.DisplayPrompt();
        do{
            Prompt.UpdateUserChoice();
        }while((Prompt._response > 5) || (Prompt._choice < 1));

        switch (Prompt._response)
        case 1:
            Journal.WriteJournal();
        break;
        case 2:
            Journal.DisplayJournal();
        break;
        case 3
            Journal.SaveJournal();
        break;
        case 4
            Journal.LoadJournal
        }
    }
    
}