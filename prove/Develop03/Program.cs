using System;
using System.ComponentModel;
using System.Data;
using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static string verse = "For God so loved the world that He gave His only begotten son that whosoever believeth in Him shall not perish but have everlasting life.";
    static string reference = " John 3:16";
    static void Main(string[] args)
    {
         Scripture scripture = new Scripture(verse, new Reference(reference), 3);
        string input = "";

        do 
        {
            Console.Clear();
            Console.Write(scripture.ToString());
            input = Console.ReadLine();

        }
        while(!input.ToUpper().Equals("Quit") && !scripture.isFinished());

    }
    
}
