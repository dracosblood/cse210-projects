//Youtube Video for Byu Pathway.
//create for: Darwin J Tovar.
//in this case i apply the knolowesge learned in the previus assignament.
//add the name of my future chane of youtube (maybe i craete son).
//i used a list for coment for simple use and ejecution.


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("C# First Classes With DarTech", "DarTech", 615);
        Comment comment1A = new Comment("Maria Lopez", "Nice good explained!");
        Comment comment1B = new Comment("Liam Carter", "thi is a good video for a program begining");
        Comment comment1C = new Comment("Sofia Ruiz", "Short, direct, and easy to follow.");
        video1.GetComments().Add(comment1A);
        video1.GetComments().Add(comment1B);
        video1.GetComments().Add(comment1C);
        videos.Add(video1);

        
        Video video2 = new Video("Top 5 Beginner Mistakes in C#", "DarTech", 840);
        Comment comment2A = new Comment("Noah Bennett", "I was definitely making mistake #2.");
        Comment comment2B = new Comment("Camila Torres", "Great pacing and clean examples.");
        Comment comment2C = new Comment("Ethan Brooks", "Subscribed right after watching this.");
        video2.GetComments().Add(comment2A);
        video2.GetComments().Add(comment2B);
        video2.GetComments().Add(comment2C);
        videos.Add(video2);

       
        Video video3 = new Video("Understanding Lists and Loops in C#", "DarTech", 530);
        Comment comment3A = new Comment("Isabella Gomez", "Foreach loops finally make sense to me.");
        Comment comment3B = new Comment("Lucas Meyer", "Nice visual breakdown of how lists work.");
        Comment comment3C = new Comment("Chloe Foster", "Thanks for keeping it straight to the point!");
        video3.GetComments().Add(comment3A);
        video3.GetComments().Add(comment3B);
        video3.GetComments().Add(comment3C);
        videos.Add(video3);

        
        Video video4 = new Video("Clean Code Tips for begin", "DarTech", 720);
        Comment comment4A = new Comment("Daniela Ortiz", "Naming variables clearly saves so much time later.");
        Comment comment4B = new Comment("Owen Hayes", "Very practical advice for begin projects.");
        Comment comment4C = new Comment("Hannah Park", "Bookmarked for future reference.");
        video4.GetComments().Add(comment4A);
        video4.GetComments().Add(comment4B);
        video4.GetComments().Add(comment4C);
        videos.Add(video4);

 
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}