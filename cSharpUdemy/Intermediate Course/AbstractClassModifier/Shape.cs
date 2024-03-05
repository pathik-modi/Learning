using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassModifier
{
  public abstract class Shape
  {
    public int Width { get; set; }
    public int Height { get; set; }
    public abstract void Draw();

    public void Copy()
    {
      System.Console.WriteLine("Copy shape into clipboard");
    }
    public void Select()
    {
      System.Console.WriteLine("Select the shape");
    }
  }
}