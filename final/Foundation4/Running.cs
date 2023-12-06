using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


class Running : Activity
{
    //Fields

    private double distance;
    private double speed;

    public double Distance
    {
        get { return  distance; }
        private set { distance = value; }
    }

    public double Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    public Running(DateTime date, double distance, double speed)
        : base(date, "Running")
    {
        Distance = distance;
        Speed = speed;
    }

    private double CalculatePace()
    {
        double paceMinutes = (60 / Speed) * Distance;
        return paceMinutes;
    }

    public override void DisplaySummary()
    {
       double paceMinutes = CalculatePace ();
       Console.WriteLine($"{Date:dd MMMM yyyy} - {Area} (min) - Distance {Distance} kilometers, " +
                        $"speed {Speed} km/h, Pace {paceMinutes:F1} min per km");
    }
    
}