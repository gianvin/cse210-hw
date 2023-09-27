using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Teacher";
        job1._company = "Santulan Elementary School";
        job1._startYear = 1998;
        job1._endYear = 2009;

        Job job2 = new Job();
        job2._jobTitle = "School Head";
        job2._company = "SDO Mlabon City";
        job2._startYear = 2009;
        job2._endYear = 2016;

        Resume myResume = new Resume();
        myResume._name = "Gina S. Ong";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
// A method that displays the Resume
        myResume.Display();
   }
}