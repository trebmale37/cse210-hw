using System;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the class video    
        Video video = new Video();
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        //Creating an instance of the comment Class
        Comment comment = new Comment();
        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();


        //Creating About three to four video with appropriate values
        video.video("How to add numbers", "Emmanuel Lambert", 30);
        video1.video("How to divide numbers", "Survived Lambert", 10);
        video2.video("How to subtract numbers", "Victoria Lambert", 10);
        video3.video("How to multiply numbers", "Jane Lambert", 50);


        //adding a list of comments for each video
        video.Display(comment.DisplayCOmment("Majoie","I really love your contents, they teach me how to do basic addition"));
        video.Display(comment.DisplayCOmment("Richard","This content has taught me basic division so well"));
        video.Display(comment.DisplayCOmment("Empress","Thanks to you, im now good at subtraaction"));
        video.Display(comment.DisplayCOmment("Tabitha","Awesome, it easy learning while watching your videos"));

        video1.Display(comment1.DisplayCOmment("Stanley","I really love your contents, they teach me how to do basic addition"));
        video1.Display(comment1.DisplayCOmment("Junior","This content has taught me basic division so well"));
        video1.Display(comment1.DisplayCOmment("Kofi","Thanks to you, im now good at subtraaction"));

        video2.Display(comment2.DisplayCOmment("Melo","I really love your contents, they teach me how to do basic addition"));
        video2.Display(comment2.DisplayCOmment("Empress","This content has taught me basic division so well"));
        video2.Display(comment2.DisplayCOmment("Dorca","Thanks to you, im now good at subtraaction"));
        video2.Display(comment2.DisplayCOmment("Samuel","Awesome, it easy learning while watching your videos"));

        video3.Display(comment3.DisplayCOmment("Joe","I really love your contents, they teach me how to do basic addition"));
        video3.Display(comment3.DisplayCOmment("Darko","This content has taught me basic division so well"));
        video3.Display(comment3.DisplayCOmment("Keymen","Thanks to you, im now good at subtraaction"));
        

        //creating a list for each video created
        List<Video>videos = new List<Video>();
        List<Comment> comments = new List<Comment>();

        videos.Add(video);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //iterating through the list of the videos and displaying the information of the video
        foreach(var video4 in videos){
            Console.WriteLine($"Title : {video4._title}");
            Console.WriteLine($"Author : {video4._author}");
            Console.WriteLine($"Length : {video4._length} seconds");
            Console.WriteLine($"Number of Comments : {video4.NoOfComment()}");
            Console.WriteLine($"Comment: ");

            foreach(string comment4 in video4.ShowComment()){
                Console.WriteLine($"{comment4}");
            }

            Console.WriteLine();
        }
    }
}