using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Lecture : Event
{
    //fields
    private string speaker;
    private int capacity;
    private List<string> registeredAttendees = new List<string>();

    //methods
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }    

    public string Speaker
    {
        get { return speaker; }
        set { speaker = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public void RegisteredAttendee(string attendee)
    {
        if (registeredAttendees.Count < capacity)
        {
            registeredAttendees.Add(attendee);
            Console.WriteLine($"{attendee} registered for the lecture.");
        }
        else
        {
            Console.WriteLine($"Sorry, the lecture is at full capacity. {attendee} cannot register.");
        }
    }
}