using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursePract.Math;

namespace CoursePract
{
    
    class Program
    {
      static void Main(string[] args)
      {
        var john = new Person();
        john.FirstName = "Pathik";
        john.LastName = "Modi";
        john.Introduce();

        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);
      }
    }
}