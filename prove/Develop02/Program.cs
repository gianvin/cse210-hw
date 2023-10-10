using System;

using System.Collections.Generic;

class Program
{
    private static int _choice;
    private static object prompt;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");
        Menu Menu = new Menu();
        Journal Journal = new Journal();
        
         do{

        Menu.DisplayMenu();
        do{
            Menu.UpdateUserChoice();
        }while((Menu._choice > 5) || (Menu._choice < 1));

        switch (Menu._choice
        case 1:
            Journal.WriteJournal();
        break;
        case 2:
            Journal.DisplayJournal();
        break;
        case 3;
            Journal.LoadJournal();
        break;
        case 4;
            Journal.SaveJournal();
        break;
        default;
        break;
        }while(Menu._choice !=5);
    {
   public void static SavetoFile(List<Journal>);  
    
    }
}