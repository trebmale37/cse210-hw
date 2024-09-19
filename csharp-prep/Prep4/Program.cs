using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Decalring variable
        int clear = 1;
        float sum = 0;
        float average = 0;

        //Creating a list of numbers
        List<int>numbers = new List<int>();

        while(clear == 1) {
            //Ask the user for a series of numbers, and append each one to a list.
            //Stop when they enter 0.
            Console.Write($"Enter a number: ");
            string word = Console.ReadLine();
            int number = int.Parse(word); // converting the string to number

            //adding the number to the list
            numbers.Add(number);

            if(number == 0){
                break;
            }
        }
        //Compute the sum, or total, of the numbers in the list.
        for(int i = 0; i < numbers.Count(); i++){
             sum = sum + numbers[i];
        }
        Console.WriteLine($"The sum of the number in the list is : {sum}");
        //Compute the average of the numbers in the list.
        average = sum / (numbers.Count() - 1);
        Console.WriteLine($"The average of the numbers in the list is : {average}");

        //Find the maximum, or largest, number in the list.
        int max = 0;
        foreach(int num in numbers){
            if(num > max){
                max = num;
            }
        }
        Console.WriteLine($"The maximum number in the list is {max}");
    }
}