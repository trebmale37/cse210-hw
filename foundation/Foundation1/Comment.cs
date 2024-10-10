using System;

public class Comment{
    //Declaring variable for the class
    public string _nameOfPerson;
    public string _commentText;

    public string DisplayCOmment(string nameOfPerson, string commentText){
        _nameOfPerson = nameOfPerson;
        _commentText = commentText;

        return $"{nameOfPerson}: {commentText}";
    }
}