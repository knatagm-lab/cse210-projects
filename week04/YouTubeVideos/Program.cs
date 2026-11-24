using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Healthy Breakfast", "Karen", 300);
        videos.Add(video1);

        Comment comment1 = new Comment("Alice", "Great video! Very informative.");
        Comment comment2 = new Comment("Bob", "I love this recipe. Thanks for sharing!");
        Comment comment3 = new Comment("Charlie", "Can't wait to try this out!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Morning Yoga Routine", "John", 600);
        videos.Add(video2);

        Comment comment4 = new Comment("David", "This yoga routine is perfect for beginners.");
        Comment comment5 = new Comment("Emma", "I feel so relaxed after following this routine.");
        Comment comment6 = new Comment("Frank", "Thanks for the clear instructions!");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Quick Workout", "Sarah", 450);
        videos.Add(video3);

        Comment comment7 = new Comment("Grace", "This workout is intense but effective!");
        Comment comment8 = new Comment("Henry", "I love how quick and efficient this workout is.");
        Comment comment9 = new Comment("Isabella", "Great for busy mornings. Thanks!");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }
        }
    }
}