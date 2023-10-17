using System;
using System.Collections.Generic;
using System.Text;

class Reference
{
    private string book;
    private string chapter;
    private string endVerse;
    private string startVerse;

    public Reference(string reference)
    {
       string[] parts = reference.Split(" "); 
       if (parts.Length == 1)
       {
        book = parts[0];
       }
       else if (parts.Length == 2)
       {
        string[] chapterVerse = parts[1].Split(":");
        book = parts[0];
        chapter = chapterVerse[0];
        string[] verseRange = chapterVerse[1].Split("-");
        startVerse = verseRange[0];
        endVerse = verseRange.Length > 1 ? verseRange[1] : startVerse;
       }
       else
       {
        return;
       }
    }
    public override string ToString()
    {
        if (!string.IsNullOrEmpty(book))
        {
            if (!string.IsNullOrEmpty(chapter))
            {
                return $"{book} {chapter}:{startVerse}";
            }
            else
            {
                return $"{book} {chapter}:{startVerse}-{endVerse}";
            }
        }
        else
        {
           return book; 
        }
    }

}