using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the activity
        BreatingActivity breatingActivity       = new BreatingActivity();
        ListingActivity listingActivity         = new ListingActivity();
        ReflectingActivity reflectionActivity   = new ReflectingActivity();

        bool repeat = true;
        
        while(true){
            Console.Clear();
            //Creating a list of choices for the user
            Console.WriteLine($"Menu Options:");
            Console.WriteLine($"  1. Breathing Activity");
            Console.WriteLine($"  2. Reflecting Activity");
            Console.WriteLine($"  3. Listing Activity");
            Console.WriteLine($"  4. Quit");

            int choice;

            //Getting the menu choice from the user
            Console.Write($"Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

        
            //selecting the preffered activity to run the code
            if(choice == 1){
                    Console.Clear();
                    breatingActivity.Run();
            }
            else if(choice == 2){
                    Console.Clear();
                    reflectionActivity.Run();
            }
            else if(choice == 3){
                    Console.Clear();
                    listingActivity.Run();
            }
             else if(choice == 4){
                    break;
            }
        }      
    }
}