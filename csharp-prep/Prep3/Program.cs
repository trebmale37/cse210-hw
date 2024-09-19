using System;

class Program
{
    static void Main(string[] args)
    {
        /*Start by asking the user for the magic number. 
        Ask the user for a guess.
        Using an if statement, determine if the user needs to guess higher or lower 
        next time, or tell them if they guessed it.
        */

        //initializing the random function
        Random magic = new Random();
        int magicnumber = magic.Next(1,101);

        //declaring a variable called magic number
        string number;
        int guess;
        do{
            //Asking the user for a guess
            //converting the string to integer
            Console.Write($"What is your guess? ");
            number = Console.ReadLine();
            guess = int.Parse(number);

            //Using a do while loop
            
                //determine if the user needs to guess higher or lower
                //or tell them if they guessed it
                if(guess == magicnumber){
                    Console.WriteLine($"You guessed it");
                }
                else if(guess < magicnumber){
                    Console.WriteLine($"Higher");
                }
                else{
                    Console.WriteLine($"Lower");
                }
            }while(guess != magicnumber);
    }
}