using System;

public class Job{
    public string _companyName;
    public string _jobTitle;
    public double _startYear;
    public double _endYear;

    public void DisplayMessage(){
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
         } 
   
}