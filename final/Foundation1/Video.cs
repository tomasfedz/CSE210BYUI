
using System;
using System.Collections.Generic;

// Define the Video class
public class Video 
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    private List<Comment> comments;

    // Constructor to initialize the video object with title, author, and length
    public Video(string title, string author, int length) 
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment) 
    {
        comments.Add(comment);
    }

    // Method to get the number of comments on the video
    public int GetNumberOfComments() 
    {
        return comments.Count;
    }

    // Method to get the list of comments associated with the video
    public List<Comment> GetComments() 
    {
        return comments;
    }
}
