using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        Video myVideo = new Video("Introduction to Computers", "Ms.Shweta");

        myVideo.AddComment("Liza", "Well explained.");
        myVideo.AddComment("Rose", "Explanation is very clear. Thank you.");

        myVideo.SetLengthInSeconds(266);

        Console.WriteLine($"Video Title: {myVideo.Title}");
        Console.WriteLine($"Video Author: {myVideo.Author}");
        Console.WriteLine($"Video Length: {myVideo.LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {myVideo.GetNumberofComments()}");

    Console.WriteLine("Comments:");
    foreach (Comment comment in myVideo.Comments)
    {
        Console.WriteLine($"{comment.Author}: {comment.Text}");
    }
    }
}