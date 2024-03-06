using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacePractice
{
  public class ConsoleLogger : ILogger
  {
    public void LogError(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      System.Console.WriteLine(message);
    }
    public void LogInfo(string message)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine(message);
    }
  }
}