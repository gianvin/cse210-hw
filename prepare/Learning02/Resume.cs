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
    }
}