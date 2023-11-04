using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>(); 

       Square s1 = new Square ("Blue", 9);

       shapes.Add(s1);

       Rectangle s2 = new Rectangle ("Red", 7, 8);
       shapes.Add(s2);

       Circle s3 = new Circle ("Yellow" , 10);
       shapes.Add(s3);
      
    }

}