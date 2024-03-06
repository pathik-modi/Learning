using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
  public class Encoding : IActivity
  {
    public void Execute()
    {
      System.Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
    }
  }
}