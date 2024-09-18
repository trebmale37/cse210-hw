using System;

class Program
{
    static void Main(string[] args)
    {
        //Decalring variables
        string firstname;
        string lastname;

        //Prompting the user for their first name
        Console.Write($"What is your your first name? ");
        firstname = Console.ReadLine();

        //Prompting the user fir their last name
        Console.Write($"What is your last name?  ");
        lastname = Console.ReadLine();

        Console.WriteLine();
        //Printing the user last name and then thier first name in a sentence
        Console.WriteLine($"Your name is {firstname}, {firstname} {lastname}");

        //Prompting the user for their first Name
        Console.Write($"What is your first name? ");
        firstname = Console.ReadLine();

        //Prompting the user for their last name
        Console.Write($"What is your last name? ");
        lastname = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}