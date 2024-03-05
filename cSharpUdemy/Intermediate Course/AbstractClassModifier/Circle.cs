using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassModifier
{
  public class Circle : Shape
  {
    public override void Draw()
    {
      System.Console.WriteLine("Draw a circle");
    }
  }
}