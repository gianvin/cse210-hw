using System;
using System.Collections.Generic;
using System.Text;

class Scripture
{
    //code for fields
    private Random random;
    private Reference reference;
    private List<Word> verse;

    public Scripture(string scripture, Reference reference)
    {
        random = new Random();
        this.reference = reference;
        this.verse = new List<Word>();
        // initialize the words in the scripture verse
        string[] words = scripture.Split(new char[] {"___"}, StringSplitOptions.removeEmptyEntries);
   
        foreach (string word in words)
        {
            Word wordObject = new Word(word);
            this.verse.Add(wordObject);
        }
    }
    public void HideWords()
    {
        foreach (var word in verse)
        {
            if(random.Next(2) == 0)
            {
                word.SetIsVisible(false);
            }
            else
            {
                word.SetIsVisible(true);
            }
        }
    }

    
}