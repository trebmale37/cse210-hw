using System;
using System.IO;

public class Journal{
    //Creating a list to store the entries
    List<string>_entries = new List<string>();

    public void AddEntry(string entry){
        //adding the entries to the list
         _entries.Add(entry);
    }

    public void Display(){
        //Displaying the entries
        foreach(string line in _entries){
            Console.WriteLine(line);
        }
    }

    public void SaveToFile(string fileName){
        //Writing to file 
        File.WriteAllLines(fileName, _entries);
    }
    
    public void LoadFromFile(string fileName){
        //creating a list to store the lines in the file
        //List<string> _journal = new List<string>();
        _entries = File.ReadAllLines(fileName).ToList();

        //foreach(string line in _journal){
            //reading from the list
          // Console.WriteLine(line);
       // }
    }
}