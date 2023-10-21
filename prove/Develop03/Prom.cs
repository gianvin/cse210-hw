using System;

class Program
{
    static void Main(string[] args)
    {
        string[] Reference  = {" John 3:16"};
    foreach (string item in Reference)
    Console.WriteLine(item);
   
// code for scripture text for the verse
    string[] scriptureVerse = {"For God so loved the world that He gave His only begotten son that whosover believeth in Him shall not perish but have verlasting life."};
    foreach (string item in scriptureVerse)
    Console.WriteLine(item);
   
    Console.WriteLine("Press enter to continue or type 'quit' to finish.");
    Console.ReadLine();
    Random random = new Random();
    int verseIndex = 0;

    while (true)
    {
        Console.Clear();
        if (verseIndex >= scriptureVerse.Length)
        {
            Console.WriteLine($"{scriptureVerse}");
            break;
        }
        string verse = scriptureVerse[verseIndex];
        Console.WriteLine(verse);

        string input = Console.ReadLine().ToLower();

    } 

    }
}