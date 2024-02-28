using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
  public class Calculator
  {
    public int Add(params int[] numbers)
    {
      int sum = 0;
      foreach (var number in numbers)
      {
        sum += number;
      }
      return sum;
    }
  }
}