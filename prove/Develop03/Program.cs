using System;

class Program
{
    static void Main(string[] args){   
        
        Reference reference = new Reference("Proverbs", 3, 5, 7);
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him,and he will make your paths straight. Do not be wise in your own eyes fear the Lord and shun evil.");

        Console.Clear();
        Console.WriteLine(scripture.DisplayScriptureText());

        while(!scripture.IsCompletlyHidden()){
            Console.Clear();
            Console.WriteLine(scripture.DisplayScriptureText());
            Console.WriteLine();

            Console.WriteLine($"Please hit enter to hide a few words or type 'quit' to end the program");
            string response = Console.ReadLine();

            if(response.ToLower() == "quit"){
                break;
            }
            else{
                scripture.HideRandomWords();
            }

            Console.Clear();
            Console.WriteLine(scripture.DisplayScriptureText());
            Console.WriteLine($"All Words are hidden");
        }
    }
}