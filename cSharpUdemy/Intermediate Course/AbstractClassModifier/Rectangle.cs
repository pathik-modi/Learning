using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassModifier
{
  public class Rectangle : Shape
  {
    public override void Draw()
    {
      System.Console.WriteLine("Draw a rectangle");
    }
  }
}