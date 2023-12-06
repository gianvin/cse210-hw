using System;

class Program
{
    static void Main(string[] args)
    {
       Running runningActivity = new Running(new DateTime(2023, 12, 1), 4, 6.0);
       StationaryBicycles stationaryBicyclesActivity = new StationaryBicycles(new DateTime (2023, 12, 1), 25.0);
       Swimming swimmingActivity = new Swimming(new DateTime(2023, 12, 1), 20, 50);

       runningActivity.DisplaySummary();
       stationaryBicyclesActivity.DisplaySummary();
       swimmingActivity.DisplaySummary();
    }
}