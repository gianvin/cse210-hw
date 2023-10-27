using System;
using System.Reflection.Metadata.Ecma335;

public class Mathematics
{
    private string _textbookSection;
    private string _problems;

 public Mathematics(string studentName, string topic, string textbookSection, string problem) 
     : base(studentName, topic)
 {
     _textbookSection =textbookSection;
    _problems = problems;
  
 }
 public string GetHomeworkList()
 {
    return $"Section {_textbookSection} Problems {_problems}";
 }

}