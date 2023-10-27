using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    //code for fields
    private List<Word> verse = new List<Word>();
    private Reference reference;

    private Random random  = new Random();
    private int wordsToHide;

    private bool allowHiding = false;

    public Scripture(string scripture, Reference reference)
      : this(scripture, reference, 3)
    {
    }
    public Scripture(string scripture, Reference reference, int wordsToHide)
    {
        parseScripture(scripture);
        this.reference = reference;
        this.wordsToHide = wordsToHide;
    }
    public override string ToString()
    {
        if (allowHiding) hideWords();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(reference.ToString());
        sb.AppendLine();
        sb.Append(String.Join(" ", verse.Select(word => word.ToString())));
        sb.AppendLine();
        sb.AppendLine();
        sb.AppendLine("Pres enter to hide words, or quit to exit.");

        allowHiding = true;
        return sb.ToString();
    }
    public bool isFinished()
    {
        var count = verse.Count(word => word.GetIsVisible());
        return count = 0;
    }
    private void hideWords()
    {
        List<Word> visibleWords = verse.FindAll(word => word.GetIsVisible());

        for (int i =0 ; i <Math.Min(wordsToHide, visibleWords.Count); i++);
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].hide();
            visibleWords = verse.FindAll(word => word.GetIsVisible());
        }
    }
    
    private void parseScripture(string Scripture)
    {
        List<string> words = scripture.split(" ").ToList();
        foreach (string word in words)
        {
            this.verse.Add(new Word(word.Trim()));
        }
    }
    
}