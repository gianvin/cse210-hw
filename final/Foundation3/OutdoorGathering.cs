using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class OutdoorGathering : Event
{
    //Fileds
    private string weatherForecast;

    //Methods

    public OutdoorGathering( string title, string description, string date, string time, string address)
        : base(title, description, date, time, address)
    {

    }

    public string WeatherForecast
    {
        get { return weatherForecast; }
        set { weatherForecast = value; }
    }

    public void DisplayWeatherMessage()
    {
        if (!string.IsNullOrEmpty(weatherForecast))
        {
            Console.WriteLine($"Weather Forecast: {weatherForecast}");
        }
        else
        {
           Console.WriteLine("Weather forecast not available."); 
        }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}