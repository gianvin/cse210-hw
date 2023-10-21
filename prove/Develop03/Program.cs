using System;
using System.Security.AccessControl;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
// code reference for a scripture verse
 {
    string[] Reference  = {" John 3:16"};
   
// code for scripture text for the verse
    string[] Scripture = {"For God so loved the world that He gave His only begotten son that whosover believeth in Him shall not perish but have verlasting life."};
Console.WriteLine(Reference.ToString()); 
Console.WriteLine(Scripture.ToString());
Console.WriteLine("Press enter to continue or type quit to finish");

// Hide some words in the verse
//Scripture.HideWords();
//Console.WriteLine("___");

 }

}
