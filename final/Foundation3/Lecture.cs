using System;
using System.Collections.Generic;

class Lecture : Event
{
    //fields
    private string speaker;
    private int capacity;
    private List<string> registerAttendees = new List<string>();

    //methods
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }    

    public string Speaker
    {
        get { return speaker; }
        private set { speaker = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        private set { capacity = value; }
    }
    

    public void RegisterAttendee(string attendee)
    {
        if (registerAttendees.Count < capacity)
        {
            registerAttendees.Add(attendee);
            Console.WriteLine($"{attendee} registered for the lecture.");
        }
        else
        {
            Console.WriteLine($"Sorry, the lecture is at full capacity. {attendee} cannot register.");
        }
    }
    public override string ToString()
    {
     return base.ToString() + $"Speaker: {Speaker}\nCapacity: {Capacity}\n";   
    }
}