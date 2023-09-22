using System;


public class Resume
{
    //Member variables section,
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Method to display to Console.
    public void Display()
    //
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Not exactly sure how the Class call works the way it does, it's considered a custom data type?
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}