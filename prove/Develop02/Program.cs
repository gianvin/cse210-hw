using System;
using System.Collections;
using System.Net;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");
        List<string> menu = new List<string>();
        menu.Add("1. Write"); 
        menu.Add("2. Display"); 
        menu.Add("3. Load"); 
        menu.Add("4. Save"); 
        menu.Add("5. Quit"); 
    }
    
}