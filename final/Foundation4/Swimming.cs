using System;
using System.Collections.Generic;

class Swimming : Activity
{
    private int laps;
    private double lapLength;

    public int Laps
    {
        get { return laps; }
        private set { lapLength = value;}
    }

    public double LapLength
    {
        get { return lapLength; }
        private set { lapLength = value;}
    }

    public Swimming(DateTime date, int laps, double lapLength)
        : base(date, "Swimming")
    {
        Laps = laps;
        LapLength = lapLength;
    }

    private double CalculatePace()
    {
        double paceMinutes = (Laps * LapLength) / 50;
        return paceMinutes;
    }

    public override void DisplaySummary()
    {
        double paceMinutes = CalculatePace();
        Console.WriteLine($"{Date:dd MMMM yyyy} - {Area} (min) - Laps {Laps}, Pace {paceMinutes:F1} min per km.");
    }
}