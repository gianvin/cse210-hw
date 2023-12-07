using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture Event
        Lecture lectureEvent = new Lecture("National Convention for School Heads on Utilization of Action Research", "Training on the Utilization of Action Research in the school level", "December 19, 2023 to December 21, 2023", "8:00 AM to 5:00 PM", "Cebu WaterFront Hotel Cebu City", "Dr. Hilario Carvajal", 100);
        lectureEvent.RegisterAttendee("Dalisay Romero");
        lectureEvent.RegisterAttendee("Robert De Guzman");

        // OutdoorGathering Event
        OutdoorGathering outdoorEvent = new OutdoorGathering("2023 National Tree Planting Activity", "Planting Activity for Youth Advocates on Stop Global Warning", "December 18, 2023", "7:00 AM", "La Mesa Dam Quezon City Philippines");
        outdoorEvent.WeatherForecast = "Sunny and Clear";
        outdoorEvent.DisplayWeatherMessage();

        //Reception Event
        Reception receptionEvent = new Reception(" 50th Birthday of Dr. Crisanto Reyes", "Birthday Celebration", "December 23, 2023", "7:00 PM", "Regalado's Event Place Rizal Avenue Caloocan Philippines");
        receptionEvent.RSVP(" leah@gmail.com");
        receptionEvent.RSVP(" grace.forever@yahoo.com");
    }
}