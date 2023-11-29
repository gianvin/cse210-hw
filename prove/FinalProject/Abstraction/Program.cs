using System;

class Program
{
    Video myVideo = new Video(",");

    myVideo.AddComment(",");

    myVideo.SetLengthInseconds(300);

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