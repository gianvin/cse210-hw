using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
class Activity
{

 //Fields
 private DateTime date;
 private string area;

 public DateTime Date
 {
    get { return date; }
    private set  { date = value; }

 }
 public string Area
 {
    get { return area;}
    private set { area = value; }
 }

 public Activity(DateTime date, string area)
 {
    Date = date;
    Area = area;
 }

 public virtual void DisplaySummary()
 {
    
 }
}