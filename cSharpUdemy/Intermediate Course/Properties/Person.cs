using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Properties
{
  public class Person
  {
    public DateTime Birthdate { get; private set; }
    // this private set means it has readonly so it needs to be set here in the constructor.
    public string Name { get; set; }
    public Person(DateTime birthdate)
    {
      Birthdate = birthdate;
    }

    public int Age
    {
      get
      {
        var timeSpan = DateTime.Today - Birthdate;
        var years = timeSpan.Days / 365;

        return years;
      }
    }
  }
}