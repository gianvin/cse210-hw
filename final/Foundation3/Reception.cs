using System;
using System.Collections.Generic;

class Reception : Event
{
    //Fields

    private List<string> rsvpList = new List<string>();

    //methods
    public Reception(string title, string description, string date, string time, string address)
        : base(title, description, date, time, address)
        {

        }

        public void RSVP(string email)
        {
            rsvpList.Add(email);
            Console.WriteLine($"RSVP received from{email} for the reception. ");
        }

    public override string ToString()
    {
     return base.ToString();  
    }
}
