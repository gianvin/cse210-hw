using System;
using System.Collections.Generic;
using System.Text;

class Word
{
    // code for fields
    private bool isVisible;
    private string word;

   //code for methods
    public Word(string word)
    {
    this.word = word;
    this.isVisible = false;
    }
    public bool GetIsVisible()
    {
        return isVisible;
    }

    public void SetIsVisible(bool isVisible)
    {
        this.isVisible = isVisible;
    }
    public override string ToString()
    {
        return isVisible ? word : "__";
    }

}