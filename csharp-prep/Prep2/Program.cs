using System;

class Program
{
    static void Main(string[] args)
    {
    /*Write a program that determines the letter grade for a course according to the following scale:

    A >= 90
    B >= 80
    C >= 70
    D >= 60
    F < 60
    Assignment
    Start by completing the core requirements, then when that part is complete, 
    if you have time, see if you can complete some of the stretch challenges as well.

    Please work through the requirements in order rather than jumping ahead to more 
    complicated steps, to ensure that everyone is following the concepts.

    Core Requirements
    Ask the user for their grade percentage, then write a series of if-elif-else 
    statements to print out the appropriate letter grade. (At this point, you'll have a 
    separate print statement for each grade letter in the appropriate block.)

    Assume that you must have at least a 70 to pass the class. After determining the 
    letter grade and printing it out. Add a separate if statement to determine if 
    the user passed the course, and if so display a message to congratulate them. If not,
    display a different message to encourage them for next time.

    Change your code from the first part, so that instead of printing the letter grade 
    in the body of each if, elif, or else block, instead create a new variable called 
    letter and then in each block, set this variable to the appropriate value. Finally, 
    after the whole series of if-elif-else statements, have a single print statement that 
    prints the letter grade once.
    */
    //Decalring variables
    string letter;
    //Prompting the user to enter their grade point
    Console.Write($"Enter your grade percentage ");
    string gradepercentage = Console.ReadLine();

    //Converting the string to number
    int grade = int.Parse(gradepercentage);

    //conditional statement for printing out the appropriate grade
    
    if(grade >= 90) {
        letter = "A";
    }
    else if(grade >= 80){
        letter = "B";
    }
    else if(grade >= 70){
        letter = "C";
    }
    else if(grade >= 60){
        letter = "D";
    }
    else {
        letter = "F";
    }

    //Printing the letter grade 
    Console.WriteLine($"Your grade is {letter}");

    if(grade >= 70){
        Console.WriteLine($"Congratulations. You passed");
    }
    else{
        Console.WriteLine($"Try Harder nextime.");
    }
    }
}