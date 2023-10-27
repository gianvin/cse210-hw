using System;
using System.Collections.Generic;
using System.Text;

public class Word
{
    // code for fields
    private string word;
    private bool isVisible = true;
    

   //code for methods
    public Word(string word)
    {
    this.word = word;
    }
    public void hide() {isVisible = false; }
    public bool GetIsVisible() => isVisible;
    public override string ToString()
    {
       return isVisible ? word : Regex.Replace(word, "[a-zA-Z]", "_");
    }

}