using System;

class Program
{
    
     // A code template for the category of things known as Job. The
    // responsibility of a Job is to hold and display Company information.
    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _jobTitle = "";
        public string _companyName = "";
        public string _startYear = "";
        public string _endYear = "";
   // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {  
        } 
    // A method that displays the the title of the job 
       
        public void ShowJobTitle()
        {
            Console.WriteLine($"{_jobTitle}");
        }
    } 
}