using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the class PromptGenerator
        PromptGenerator prompt = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();
        DateTime date = new DateTime();

        //Declaring variables
        int choice;
        bool repeat =  false;

        while(repeat != true){
             //writing a menu for the journal
            Console.WriteLine($"Please select one of the following choices;");
            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. Quit");

            Console.Write($"What would you like to do? ");
            //parsing the variable string into integer
            choice = int.Parse(Console.ReadLine());

            //Creating a conditional statement for all the following choices
            if(choice == 1){
                //Storing and displaying a random question from the promptGenerator
                entry._promptText = prompt.showlist();
                Console.WriteLine($"{entry._promptText}");
                entry._entryText = Console.ReadLine();

                //storing the date of the int the
                date = DateTime.Now;  
                entry._date =  date.ToShortDateString();

                //displaying the entry
                entry.entryDisplay();
                //Console.WriteLine($"{entry.entryDisplay()}");

                //adding the entry into the list
                journal.AddEntry(entry.entryDisplay());

                Console.WriteLine();
            }
            else if(choice == 2){
                journal.Display();
                Console.WriteLine();
            }
            else if(choice == 3){
                //Asking the user for the file name
                Console.WriteLine($"What is the name of the file?");
                string fileName = Console.ReadLine();
                
                //Displaying the content from the saved file
                journal.LoadFromFile(fileName);
                Console.WriteLine();
            }
            else if(choice == 4){
                //Asking the user the name of the file
                Console.WriteLine($"what is the name of the file?");
                string filename = Console.ReadLine();

                //calling the method of Save to File from the journal class
                journal.SaveToFile(filename);
                Console.WriteLine();
            }
            else{
                repeat = true;
            }
        }
    }
}