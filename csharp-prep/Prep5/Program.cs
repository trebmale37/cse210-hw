using System;

class Program
{
    static void Main(string[] args)
    {
        //Displaying the welcome message
        DisplayWelcomeMessage();

        //Display the prompt user name and number
        string name = PromptUserName();
        int number  = PromptUserNumber();

        //calculating the square of the number
        int square = SquareNumber(number);

        //Diaplay the name of the user and the squared number
        DisplayResult(name, square);
    }

    //DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcomeMessage(){
        Console.WriteLine($"Welcome to the Program!");
    }

    //PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName(){
        //Asking the user for their name
        Console.Write($"Please enter your name: ");
        string username = Console.ReadLine();

        //Returing the username
        return username;
    }

    //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)    
    static int PromptUserNumber(){
        //Asking the user for their number and converting the string to number
        Console.Write($"Please enter your favorite number: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);

        //returning the number from the user
        return num;
    }

    //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number){
        //computing the square of the number
        int square = number * number;

        //returning the square of the number
        return square;
    }

    //DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string username, int square){
        //display the username and the square number
        Console.WriteLine($"{username}, the square of your number is {square}");
       
    }
}