using System;

public class Job
{
    //Member variables here
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = -1;
    public int _endYear = -1;

    //Method that could actually be removed as it is deprecated for
    //the Resume class instead.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}