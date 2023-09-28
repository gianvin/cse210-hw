using System;
using System.Threading.Tasks.Dataflow;

public class Resume
{
    public string _name;
    //Initialize the list to new list
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
    // Create the loop for Job
    foreach (Job job in _jobs)
    {
        // Call the Display method on each job
        job.Display();
    }
    }
}