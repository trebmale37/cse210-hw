using System;

public class Video{
    //Creating variables for the class Video
    public string _title;
    public string _author;
    public double _length;
    List<string>_comment = new List<string>();

    //method to Display the name title, author and length of the video
    public string video(string title, string author, double length){
        //initializing variables for use
        _title = title;
        _author = author;
        _length = length;

        return $"The title of the video is: {title}. It was created by {author} and is {length} seconds long. Its has {NoOfComment()}";
    }
    //method for displaying the name of person and comment 
    public void Display(string comment){
        _comment.Add(comment);
    }
    //method for the video class
    public int NoOfComment(){
        //getting the number of comments
       return  _comment.Count;
    }

    //method for displaying the comment for each video
    public List<string> ShowComment(){
         return _comment;
    }
}
