using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string[] Reference  = {" John 3:16","1 Nephi 1:7"};
    foreach (string item in Reference)
    Console.WriteLine(item);
   
// code for scripture text for the verse
    string[] scriptureVerses = {"For God so loved the world that He gave His only begotten son that whosoever believeth in Him shall not perish but have verlasting life.", "And it came to pass that I, nephi, said unto my Father: I will go and do the things which the Lord hath commandeth, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."};
    foreach (string item in scriptureVerses)
    Console.WriteLine(item);
   
    Console.WriteLine("Press enter to continue or type 'quit' to finish.");
    Console.ReadLine();
    Random random = new Random();
    int verseIndex = 0;

    while (true)
    {
        Console.Clear();
        if (verseIndex >= scriptureVerses.Length)
        {
            Console.WriteLine("You are done will all the scripture verses");
            break;
        }
        
        string verse = scriptureVerses[verseIndex];
        Console.WriteLine(verse);

        string input = Console.ReadLine().ToLower();
        if (input == "quit")
        {
            Console.WriteLine(" You have memorized the scripture verse.");
        }

    } 

    }
}