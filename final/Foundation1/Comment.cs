using System;
using System.Collections.Generic;

public class Comment {
    // Properties to store the commenter's name and the comment text
    public string CommenterName { get; set; }
    public string Text { get; set; }
    
// Constructor to initialize the comment object with the commenter's name and text
    public Comment(string commenterName, string text) {
        CommenterName = commenterName;
        Text = text;
    }
}