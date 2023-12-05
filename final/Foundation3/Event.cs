using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Event
{  
    //fields
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;

    //methods
    public Event(string title, string description, string date, string time, string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }

    public string Time
    {
       get { return time; }
       set { time = value; } 
    }

    public string Address
    {
        get { return address; }
        set {address = value; }
    }

}