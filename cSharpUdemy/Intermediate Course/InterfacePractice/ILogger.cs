using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacePractice
{
  public interface ILogger
  {
    void LogInfo(string message);
    void LogError(string message);
  }
}