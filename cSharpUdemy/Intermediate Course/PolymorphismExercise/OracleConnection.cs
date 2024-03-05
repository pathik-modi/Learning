using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
  public class OracleConnection : DbConnection
  {
    public OracleConnection(string connectionString) : base(connectionString)
    {
      Console.WriteLine("Now using Oracle connection...");
    }
    public override void OpenConnection()
    {
      if (IsConnected)
      {
        throw new InvalidOperationException("Already connected");
      }
      else
      {
        System.Console.WriteLine($"Oracle Connection open with {ConnectionString}");
        IsConnected = true;
      }
    }
    public override void CloseConnection()
    {
      if (!IsConnected)
      {
        throw new InvalidOperationException("Already disconnected");
      }
      else
      {
        System.Console.WriteLine("Oracle Connection close");
        IsConnected = false;
      }
    }
  }
}