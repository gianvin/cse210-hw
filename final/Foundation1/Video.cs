using System;

class Video
{
    public string Title { get; set;}
    public string Author { get; set;}

    private List<Comment> comments = new List<Comment>();

    public int LengthInSeconds {get; private set;}

    public Video(string title, string author)
    {
        Title = title;
        Author = author;
    }
    public void AddComment(string author, string text)
    {
        Comment comment = new Comment(author, text);
        comments.Add(comment);
    }

    public int GetNumberofComments()
    {
        return comments.Count;
    }

    public void SetLengthInSeconds(int length)
    {
        LengthInSeconds = length;
    }
    public List<Comment> Comments
    {
        get { return comments;}
    }
   
}