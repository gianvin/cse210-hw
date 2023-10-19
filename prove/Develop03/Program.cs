using System;
using System.Security.AccessControl;
using System.Xml.Linq;

// code reference for a scripture verse
Reference reference = new(" John 3:16 ");

// code for scripture text for the verse
Scripture scripture = new Scripture("For God so loved the world that He gave His only begotten son that whosover believeth in Him shall not perish but have verlasting life. ");

Console.WriteLine("Original Verse:");
Console.WriteLine(scripture.ToString());
Console.WriteLine("Press enter to continue or type quit to finish");

if (scripture.IsFinished())
{
    Console.WriteLine("\nAll words are hidden. Memorizing is finished");
}
else
{
    Console.WriteLine("\nSome words are still visible. memorizing is not finished.");
}
// All words visible
foreach (Word word in scripture.GetVerse())
{
    word.SetIsVisible(true);
}
Console.WriteLine("\nVerse with all words visible:");
Console.WriteLine(scripture.ToString());
// Hide some words in the verse
scripture.HideWords();
Console.WriteLine(" ");
Console.WriteLine(scripture.ToString());
