using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize new object named job1
        Job job1 = new Job();
        //job1 has these four member variables that were created..
        //we are adding our information to job1 as follows.
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        //Initialize a second new object named job2
        Job job2 = new Job();
        //Same as above, adding more information to our second object named job2.
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;


        /* third example
        * Job job3 = new Job();
        * job3._jobTitle = "Termite Technician";
        * job3._company = "Orkin Pest Control";
        * job3._startYear = 2019;
        * job3._endYear = 2023;
        */


        //Initialize a object named myResume from the Resume class(blueprint).
        Resume myResume = new Resume();
        //Add a name to the member variable.
        myResume._name = "Austin Campbell";
        //Add each job object we created to the myResume object's list that is
        //defined as a list.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //myResume._jobs.Add(job3); //Would add my actual job to the list as well.
        
        //Call the method Display() which just writes to the line with name,
        //and loops through each job that has been added to the list.
        myResume.Display();
    }
}