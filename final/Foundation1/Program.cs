using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a list to store video objects
        List<Video> videos = new List<Video>();

       // Create video objects and add comments to them
        Video video1 = new Video("Product Review", "TechGuru", 300);
        video1.AddComment(new Comment("Alice", "Great review, very informative!"));
        video1.AddComment(new Comment("Bob", "I hate this product. Too overpriced."));
        video1.AddComment(new Comment("Charlie", "More details please!"));
        videos.Add(video1);

        Video video2 = new Video("Unboxing", "GearFan", 450);
        video2.AddComment(new Comment("Dave", "Awesome unboxing any more details in the coming videos?"));
        video2.AddComment(new Comment("Eve", "Can’t wait to buy it."));
        video2.AddComment(new Comment("Frank", "Nice video quality. But I expected more from this product."));
        videos.Add(video2);

        Video video3 = new Video("Tutorial", "DIYMaster", 600);
        video3.AddComment(new Comment("Grace", "Super helpful!"));
        video3.AddComment(new Comment("Hank", "Thanks for this."));
        video3.AddComment(new Comment("Ivy", "You took too long to get to the point. Lost 10 minutes of my life with your intro"));
        videos.Add(video3);

        // Display the details of each video and its comments
        // Loop through each video and print its details
        foreach (Video video in videos) {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.GetComments()) {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}