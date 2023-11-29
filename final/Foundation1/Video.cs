using System;

class Video
{
    public string Title { get; set;}
    public string Author { get; set;}

    public List<Comment> comments = new List<Comment>();
    public int LengthInSeconds {get; set;}

    public Video(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void SetLengthInSeconds(int length)
    {
        LengthInSeconds = length;
    }
   
}