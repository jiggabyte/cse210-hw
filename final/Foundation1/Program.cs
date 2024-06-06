using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "John Doe", 600);
        Video video2 = new Video("Understanding OOP Concepts", "Jane Smith", 1200);
        Video video3 = new Video("Advanced C# Techniques", "Chris Johnson", 1800);
        Video video4 = new Video("C# for Beginners", "Patricia Lee", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I didn't understand the part about classes."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "This was really informative."));
        video2.AddComment(new Comment("Eve", "Well explained, thank you!"));
        video2.AddComment(new Comment("Frank", "Can you make a video on interfaces?"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Advanced stuff but very useful."));
        video3.AddComment(new Comment("Heidi", "Loved the examples used."));
        video3.AddComment(new Comment("Ivan", "A bit too fast for me."));

        // Add comments to video4
        video4.AddComment(new Comment("Judy", "Perfect for beginners."));
        video4.AddComment(new Comment("Mallory", "Good pacing and easy to follow."));
        video4.AddComment(new Comment("Niaj", "Can you cover more topics next time?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display details of each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Video Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    "- " + comment.GetCommenterName() + ": " + comment.GetCommentText()
                );
            }
            Console.WriteLine();
        }
    }
}
