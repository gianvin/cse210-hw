using System;
using System.Collections.Generic;


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
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string Title
    {
        get { return title; }
        private set { title = value; }
    }

    public string Description
    {
        get { return description; }
        private set { description = value; }
    }

    public string Date
    {
        get { return date; }
        private set { date = value; }
    }

    public string Time
    {
       get { return time; }
       private set { time = value; } 
    }

    public string Address
    {
        get { return address; }
        private set {address = value; }
    }

    public override string ToString()
    {
       return $" Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}\n";
    }

}