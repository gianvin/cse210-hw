using System;
using System.Collections.Generic;
using System.Text;

class Scripture
{
    //code for fields
    private Random random;
    private Reference reference;
    private List<Word> verse;
    private string v;

    public Scripture(string v)
    {
        this.v = v;
    }

    public Scripture(string scripture, Reference reference)
    {
        random = new Random();
        this.reference = reference;
        this.verse = new List<Word>();
        // initialize the words in the scripture verse
        string[] words = scripture.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
   
        foreach (string word in words)
        {
            Word wordObject = new(word);
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
    public bool IsFinished()
    {
       foreach (Word word in verse)
       {
        if (!word.GetIsVisible())
        {
            return false;
        }

        return true;
       }
       return verse.All(word => word.GetIsVisible());
    }

    public override string ToString()
    {
       StringBuilder scriptureText = new();

       foreach (Word word in verse)
       {
        scriptureText.Append(word.ToString()).Append(" ");
       } 
       return scriptureText.ToString().Trim();
    }

    internal IEnumerable<Word> GetVerse()
    {
        throw new NotImplementedException();
    }
}