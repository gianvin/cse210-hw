using System;
using System.Collections.Generic;

class StationaryBicycles : Activity
{
    //Fields
    private double speed;
    public double Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    public StationaryBicycles(DateTime date, double speed)
        : base(date, "Stationary Bicycles")
    {
        Speed = speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{Date: dd MMMM yyyy} - {Area} - Speed {Speed} km/h.");
    }
}