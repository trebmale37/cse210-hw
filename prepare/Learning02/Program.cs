using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating an object of the class Job and Resume
        Resume resume   =   new Resume();
        Job job1        =   new Job();
        Job job2        =   new Job();
        
        //initializing values to the attributes of the Job Object 1
        job1._jobTitle      =   "Software Engineer";
        job1._companyName   =   "Microsoft";
        job1._startYear     =   2019;
        job1._endYear       =   2022;

        //initializing values to the attributes of the Job Object 2
        job2._jobTitle      =   "Manager";
        job2._companyName   =   "Apple";
        job2._startYear     =   2012;
        job2._endYear       =   2023;

        //initializing values to the attributes of the Resume Object 1
        resume._personName =   "Emmanuel Lambert";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);          

        resume.Message();
    }
}