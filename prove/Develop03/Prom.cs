using System;
using System.ComponentModel;
using System.Data;
using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        string[] Reference  = {" John 3:16"};
    foreach (string item in Reference)
    Console.WriteLine(item);
   
// code for scripture text for the verse
    string[] scriptureVerse = {"For God so loved the world that He gave His only begotten son that whosoever believeth in Him shall not perish but have everlasting life."};
    foreach (string item in scriptureVerse)
    Console.WriteLine(item);
   
    Console.WriteLine("Press enter to continue or type 'quit' to finish.");
    Console.ReadLine();
    Random random = new Random();
    int scriptureVerseIndex = 0;

    while (true)
    {
        Console.Clear();
        if (scriptureVerseIndex >=scriptureVerse.Length)
        {
            Console.WriteLine($"{scriptureVerse}");
            break;
        }
        string verse = scriptureVerse[scriptureVerseIndex];
        string hiddenWords = HideWords(verse);
        Console.WriteLine(hiddenWords);
        string input = Console.ReadLine().ToLower();
        if (input == "quit")
        {
            Console.WriteLine("Finish");
            break;
        }
        
        scriptureVerseIndex++;
    }


    }
    static string HideWords(string verse)
    {
        string[] wordsToHide = {"_Son_", "_everlasting life_",};
        foreach (var word in wordsToHide)
        {
            verse = verse.Replace(word, new string('_', word.Length));
        }
        return verse;
    }
    
}
