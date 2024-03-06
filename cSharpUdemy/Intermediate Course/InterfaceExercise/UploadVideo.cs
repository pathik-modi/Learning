using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
  public class UploadVideo : IActivity
  {
    public void Execute()
    {
      System.Console.WriteLine("Upload a video to a cloud storage.");
    }
  }
}